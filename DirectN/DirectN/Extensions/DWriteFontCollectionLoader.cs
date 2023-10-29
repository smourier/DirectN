using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    public class DWriteFontCollectionLoader : IDWriteFontCollectionLoader, IDisposable
    {
        private bool _disposedValue = false;
        private readonly FontFileLoader _loader = new FontFileLoader();

        public DWriteFontCollectionLoader()
        {
            using (var fac = DWriteFunctions.DWriteCreateFactory())
            {
                fac.Object.RegisterFontCollectionLoader(this).ThrowOnError();
                fac.Object.RegisterFontFileLoader(_loader).ThrowOnError();
            }
        }

        public virtual Func<IDWriteFactory, byte[], IEnumerable<DWriteFontFile>> EnumerableFunc { get; set; }

        HRESULT IDWriteFontCollectionLoader.CreateEnumeratorFromKey(IDWriteFactory factory, IntPtr collectionKey, uint collectionKeySize, out IDWriteFontFileEnumerator fontFileEnumerator)
        {
            var func = EnumerableFunc;
            if (func == null)
            {
                fontFileEnumerator = null;
                ComError.SetError(nameof(EnumerableFunc) + " was not set.");
                return HRESULTS.DISP_E_EXCEPTION;
            }

            byte[] key;
            if (collectionKey == IntPtr.Zero || collectionKeySize == 0)
            {
                key = null;
            }
            else
            {
                key = new byte[collectionKeySize];
                Marshal.Copy(collectionKey, key, 0, (int)collectionKeySize);
            }

            var enumerable = func(factory, key);
            if (enumerable == null)
            {
                fontFileEnumerator = null;
                ComError.SetError(nameof(EnumerableFunc) + " returned nothing.");
                return HRESULTS.DISP_E_EXCEPTION;
            }

            var enumerator = enumerable.GetEnumerator();
            if (enumerator == null)
            {
                fontFileEnumerator = null;
                ComError.SetError(nameof(EnumerableFunc) + " returned a null enumerator.");
                return HRESULTS.DISP_E_EXCEPTION;
            }

            fontFileEnumerator = new FontFileEnumerator(factory, _loader, enumerator);
            return HRESULTS.S_OK;
        }

        private class FontFileEnumerator : IDWriteFontFileEnumerator
        {
            private readonly IDWriteFactory _factory;
            private readonly IEnumerator<DWriteFontFile> _enumerator;
            private readonly FontFileLoader _loader;

            public FontFileEnumerator(IDWriteFactory factory, FontFileLoader loader, IEnumerator<DWriteFontFile> enumerator)
            {
                _factory = factory;
                _loader = loader;
                _enumerator = enumerator;
            }

            public HRESULT GetCurrentFontFile(out IDWriteFontFile fontFile)
            {
                DWriteFontFile file;
                try
                {
                    file = _enumerator.Current;
                }
                catch (Exception e)
                {
                    ComError.SetError(e.GetAllMessages());
                    fontFile = null;
                    return HRESULTS.DISP_E_EXCEPTION;
                }

                if (file is DWriteFontStreamFile sf && sf.FilePath != null)
                {
                    using (var mem = new ComMemory(Marshal.SizeOf<long>()))
                    {
                        if (sf.LastWriteTime.HasValue)
                        {
                            Marshal.WriteInt64(mem.Pointer, sf.LastWriteTime.Value.ToFileTime());
                        }

                        var ptr = sf.LastWriteTime.HasValue ? mem.Pointer : IntPtr.Zero;
                        return _factory.CreateFontFileReference(sf.FilePath, ptr, out fontFile);
                    }
                }

                var stream = new FontFileStream(file);
                _loader.AddStream(stream);
                return _factory.CreateCustomFontFileReference(stream.Key, (uint)stream.KeySize, _loader, out fontFile);
            }

            public HRESULT MoveNext(out bool hasCurrentFile)
            {
                try
                {
                    hasCurrentFile = _enumerator.MoveNext();
                    return HRESULTS.S_OK;
                }
                catch (Exception e)
                {
                    ComError.SetError(e.GetAllMessages());
                    hasCurrentFile = false;
                    return HRESULTS.DISP_E_EXCEPTION;
                }
            }
        }

        private class FontFileLoader : IDWriteFontFileLoader, IDisposable
        {
            private readonly ConcurrentDictionary<int, FontFileStream> _streams = new ConcurrentDictionary<int, FontFileStream>();
            private int _index;

            public void AddStream(FontFileStream stream)
            {
                _streams[_index] = stream;
                Marshal.WriteInt32(stream.Key, _index);
                _index++;
            }

            public void Dispose()
            {
                foreach (var stream in _streams)
                {
                    stream.Value.Dispose();
                }
            }

            HRESULT IDWriteFontFileLoader.CreateStreamFromKey(IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, out IDWriteFontFileStream fontFileStream)
            {
                if (fontFileReferenceKeySize == 4)
                {
                    var index = Marshal.ReadInt32(fontFileReferenceKey);
                    _streams.TryGetValue(index, out var stream);
                    if (stream != null)
                    {
                        fontFileStream = stream;
                        return HRESULTS.S_OK;
                    }
                }

                fontFileStream = null;
                return HRESULTS.E_UNEXPECTED;
            }
        }

        private class FontFileStream : IDWriteFontFileStream, IDisposable
        {
            private readonly DWriteFontFile _file;

            public FontFileStream(DWriteFontFile file)
            {
                _file = file;
                KeySize = 4;
                Key = Marshal.AllocHGlobal(KeySize);
            }

            public IntPtr Key { get; }
            public int KeySize { get; }

            public void Dispose()
            {
                ((IDisposable)_file)?.Dispose();
                Marshal.FreeHGlobal(Key);
            }

            HRESULT IDWriteFontFileStream.GetFileSize(out ulong fileSize)
            {
                if (_file.Length.HasValue)
                {
                    fileSize = (ulong)_file.Length.Value;
                    return HRESULTS.S_OK;
                }

                fileSize = 0;
                return HRESULTS.E_NOTIMPL;
            }

            HRESULT IDWriteFontFileStream.GetLastWriteTime(out ulong lastWriteTime)
            {
                if (_file.LastWriteTime.HasValue)
                {
                    lastWriteTime = (ulong)_file.LastWriteTime.Value.ToFileTime();
                    return HRESULTS.S_OK;
                }

                lastWriteTime = 0;
                return HRESULTS.E_NOTIMPL;
            }

            HRESULT IDWriteFontFileStream.ReadFileFragment(out IntPtr fragmentStart, ulong fileOffset, ulong fragmentSize, out IntPtr fragmentContext)
            {
                fragmentStart = IntPtr.Zero;
                fragmentContext = IntPtr.Zero;
                var bytes = _file.ReadFileFragment((long)fileOffset, (int)fragmentSize, out var read);
                if (bytes.IsEmpty() || read == 0)
                    return HRESULTS.E_FAIL;

                if (read < 0 || read > bytes.Length)
                {
                    ComError.SetError("Invalid ReadFileFragment implementation.");
                    return HRESULTS.DISP_E_EXCEPTION;
                }

                fragmentContext = Marshal.AllocHGlobal(read);
                fragmentStart = fragmentContext;
                Marshal.Copy(bytes, 0, fragmentContext, read);
                return HRESULTS.S_OK;
            }

            void IDWriteFontFileStream.ReleaseFileFragment(IntPtr fragmentContext) => Marshal.FreeHGlobal(fragmentContext);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                using (var fac = DWriteFunctions.DWriteCreateFactory())
                {
                    fac.Object.UnregisterFontFileLoader(_loader).ThrowOnError();
                    fac.Object.UnregisterFontCollectionLoader(this).ThrowOnError();
                }

                _loader.Dispose();
                _disposedValue = true;
            }
        }

        ~DWriteFontCollectionLoader() { Dispose(false); }
        public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
    }
}
