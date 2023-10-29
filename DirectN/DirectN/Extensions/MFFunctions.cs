using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static class MFFunctions
    {
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFShutdown();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFStartup(uint Version, uint dwFlags);

        public static void MFStartup() => MFStartup((Constants.MF_SDK_VERSION << 16) | Constants.MF_API_VERSION, Constants.MFSTARTUP_FULL).ThrowOnError();

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTRegisterLocal(IClassFactory pClassFactory, [MarshalAs(UnmanagedType.LPStruct)] Guid guidCategory, [MarshalAs(UnmanagedType.LPWStr)] string pszName, _MFT_ENUM_FLAG Flags, uint cInputTypes, __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pInputTypes, uint cOutputTypes, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] __MIDL___MIDL_itf_mfobjects_0000_0008_0003[] pOutputTypes);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTUnregisterLocal(IClassFactory pClassFactory);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFGetMFTMerit([MarshalAs(UnmanagedType.IUnknown)] object pMFT, uint cbVerifier, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] verifier, out uint merit);

        public static int? MFGetMFTMerit(object transform)
        {
            if (transform == null)
                throw new ArgumentNullException(nameof(transform));

            var hr = MFGetMFTMerit(transform, 0, null, out var merit);
            if (hr.IsError)
                return null;

            return (int)merit;
        }

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromMediaSink(IMFMediaSink pMediaSink, IMFAttributes pAttributes, out IMFSinkWriter ppSinkWriter);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType pIMFMediaType, IMFSampleGrabberSinkCallback pIMFSampleGrabberSinkCallback, out IMFActivate ppIActivate);

        public static ComObject<IMFActivate> MFCreateSampleGrabberSinkActivate(IMFMediaType type, IMFSampleGrabberSinkCallback callback) => MFCreateSampleGrabberSinkActivate<IMFActivate>(type, callback);
        public static ComObject<T> MFCreateSampleGrabberSinkActivate<T>(IMFMediaType type, IMFSampleGrabberSinkCallback callback) where T : IMFActivate
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (callback == null)
                throw new ArgumentNullException(nameof(callback));

            MFCreateSampleGrabberSinkActivate(type, callback, out var sink).ThrowOnError();
            return new ComObject<T>((T)sink);
        }

        public static ComObject<IMFSinkWriter> MFCreateSinkWriterFromMediaSink(IMFMediaSink sink, IMFAttributes attributes = null) => MFCreateSinkWriterFromMediaSink<IMFSinkWriter>(sink, attributes);
        public static ComObject<T> MFCreateSinkWriterFromMediaSink<T>(IMFMediaSink sink, IMFAttributes attributes = null) where T : IMFSinkWriter
        {
            if (sink == null)
                throw new ArgumentNullException(nameof(sink));

            MFCreateSinkWriterFromMediaSink(sink, attributes, out var writer).ThrowOnError();
            return new ComObject<T>((T)writer);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStream(IStream pStream, out IMFByteStream ppByteStream);

        public static ComObject<IMFByteStream> MFCreateMFByteStreamOnStream(this IStream stream) => MFCreateMFByteStreamOnStream<IMFByteStream>(stream);
        public static ComObject<T> MFCreateMFByteStreamOnStream<T>(this IStream stream) where T : IMFByteStream
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            MFCreateMFByteStreamOnStream(stream, out var bs).ThrowOnError();
            return new ComObject<T>((T)bs);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaType(out IMFMediaType ppMFType);

        public static ComObject<IMFMediaType> MFCreateMediaType() => MFCreateMediaType<IMFMediaType>();
        public static ComObject<T> MFCreateMediaType<T>() where T : IMFMediaType
        {
            MFCreateMediaType(out var type).ThrowOnError();
            return new ComObject<T>((T)type);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateAttributes(out IMFAttributes ppMFAttributes, uint cInitialSize);

        public static ComObject<IMFAttributes> MFCreateAttributes(uint initialSize = 0) => MFCreateAttributes<IMFAttributes>(initialSize);
        public static ComObject<T> MFCreateAttributes<T>(uint initialSize = 0) where T : IMFAttributes
        {
            MFCreateAttributes(out var attributes, initialSize).ThrowOnError();
            return new ComObject<T>((T)attributes);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFAverageTimePerFrameToFrameRate(ulong unAverageTimePerFrame, out uint punNumerator, out uint punDenominator);

        [DllImport("mfreadwrite", ExactSpelling = true)]
        public static extern HRESULT MFCreateSinkWriterFromURL([MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL, IMFByteStream pByteStream, IMFAttributes pAttributes, out IMFSinkWriter ppSinkWriter);

        public static ComObject<IMFSinkWriter> MFCreateSinkWriterFromURL(string outputUrl, IMFByteStream byteStream, IMFAttributes attributes) => MFCreateSinkWriterFromURL<IMFSinkWriter>(outputUrl, byteStream, attributes);
        public static ComObject<T> MFCreateSinkWriterFromURL<T>(string outputURL, IMFByteStream byteStream, IMFAttributes attributes) where T : IMFSinkWriter
        {
            if (attributes == null)
                throw new ArgumentNullException(nameof(attributes));

            MFCreateSinkWriterFromURL(outputURL, byteStream, attributes, out var writer).ThrowOnError();
            return new ComObject<T>((T)writer);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMemoryBuffer(uint cbMaxLength, out IMFMediaBuffer ppBuffer);

        public static ComObject<IMFMediaBuffer> MFCreateMemoryBuffer(uint cbMaxLength) => MFCreateMemoryBuffer<IMFMediaBuffer>(cbMaxLength);
        public static ComObject<T> MFCreateMemoryBuffer<T>(uint cbMaxLength) where T : IMFMediaBuffer
        {
            MFCreateMemoryBuffer(cbMaxLength, out var sample).ThrowOnError();
            return new ComObject<T>((T)sample);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSample(out IMFSample ppIMFSample);

        public static ComObject<IMFSample> MFCreateSample() => MFCreateSample<IMFSample>();
        public static ComObject<T> MFCreateSample<T>() where T : IMFSample
        {
            MFCreateSample(out var sample).ThrowOnError();
            return new ComObject<T>((T)sample);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateDXGISurfaceBuffer([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object punkSurface, uint uSubresourceIndex, bool fBottomUpWhenLinear, out IMFMediaBuffer ppBuffer);

        public static ComObject<T> MFCreateDXGISurfaceBuffer<T>(object surface, int resourceIndex, bool bottomUpWhenLinear) where T : IMFMediaBuffer
        {
            MFCreateDXGISurfaceBuffer(typeof(ID3D11Texture2D).GUID, surface, (uint)resourceIndex, bottomUpWhenLinear, out var buffer).ThrowOnError();
            return new ComObject<T>((T)buffer);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateDXGIDeviceManager(out uint resetToken, out IMFDXGIDeviceManager ppDeviceManager);

        public static ComObject<IMFDXGIDeviceManager> MFCreateDXGIDeviceManager() => MFCreateDXGIDeviceManager();
        public static ComObject<IMFDXGIDeviceManager> MFCreateDXGIDeviceManager(out uint resetToken) => MFCreateDXGIDeviceManager<IMFDXGIDeviceManager>(out resetToken);
        public static ComObject<T> MFCreateDXGIDeviceManager<T>(out uint resetToken) where T : IMFDXGIDeviceManager
        {
            MFCreateDXGIDeviceManager(out resetToken, out var manager).ThrowOnError();
            return new ComObject<T>((T)manager);
        }

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTEnumEx(
            Guid guidCategory,
            _MFT_ENUM_FLAG Flags,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pInputType,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out IMFActivate[] pppMFTActivate,
            out int pnumMFTActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFTEnumEx(
            Guid guidCategory,
            _MFT_ENUM_FLAG Flags,
            IntPtr pInputType,
            ref __MIDL___MIDL_itf_mfobjects_0000_0008_0003 pOutputType,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] out IMFActivate[] pppMFTActivate,
            out int pnumMFTActivate);

        public static IReadOnlyList<ComObject<IMFActivate>> MFTEnumEx(Guid categoryId, _MFT_ENUM_FLAG flags, __MIDL___MIDL_itf_mfobjects_0000_0008_0003? inputType = null, __MIDL___MIDL_itf_mfobjects_0000_0008_0003? outputType = null)
        {
            var it = inputType ?? new __MIDL___MIDL_itf_mfobjects_0000_0008_0003();
            var ot = outputType ?? new __MIDL___MIDL_itf_mfobjects_0000_0008_0003();
            MFTEnumEx(categoryId, flags, IntPtr.Zero, ref ot, out var activate, out var count).ThrowOnError();
            var list = new List<ComObject<IMFActivate>>();
            for (var i = 0; i < count; i++)
            {
                //if (activate[i] is IMFGetService svc)
                //{
                //    var hr = svc.GetService(MFConstants.MF_WRAPPED_OBJECT, typeof(IClassFactory).GUID, out var classFactory);
                //}
                list.Add(new ComObject<IMFActivate>(activate[i]));
            }
            return list;
        }
    }
}
