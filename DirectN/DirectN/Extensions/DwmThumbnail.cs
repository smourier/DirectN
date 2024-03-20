using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public class DwmThumbnail : IDisposable
    {
        private IntPtr _id;

        public DwmThumbnail(IntPtr hwndDestination, IntPtr hwndSource, bool throwOnError = true)
        {
            DwmRegisterThumbnail(hwndDestination, hwndSource, out _id).ThrowOnError(throwOnError);
        }

        public IntPtr Id => _id;

        public tagSIZE SourceSize
        {
            get
            {
                DwmQueryThumbnailSourceSize(CheckDisposed(), out var size);
                return size;
            }
        }

        public virtual HRESULT UpdateThumbnailProperties(DWM_THUMBNAIL_PROPERTIES properties, bool throwOnError = true) => DwmUpdateThumbnailProperties(CheckDisposed(), ref properties).ThrowOnError(throwOnError);

        public override string ToString() => Id.ToString();

        protected IntPtr CheckDisposed()
        {
            var id = Id;
            if (id == IntPtr.Zero)
                throw new ObjectDisposedException(nameof(Id));

            return id;
        }

        protected virtual void Dispose(bool disposing)
        {
            var id = Interlocked.Exchange(ref _id, IntPtr.Zero);
            if (id != IntPtr.Zero)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                }

                // free unmanaged resources (unmanaged objects) and override finalizer
                // set large fields to null
                DwmUnregisterThumbnail(id);
            }
        }

        ~DwmThumbnail() { Dispose(disposing: false); }
        public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }

        public static bool IsCompositionEnabled { get => DwmIsCompositionEnabled(out var enabled).IsSuccess && enabled; set => DwmEnableComposition(value); }

        [DllImport("dwmapi")]
        private static extern HRESULT DwmRegisterThumbnail(IntPtr hwndDestination, IntPtr hwndSource, out IntPtr phThumbnailId);

        [DllImport("dwmapi")]
        private static extern HRESULT DwmUnregisterThumbnail(IntPtr hThumbnailId);

        [DllImport("dwmapi")]
        private static extern HRESULT DwmQueryThumbnailSourceSize(IntPtr hThumbnail, out tagSIZE pSize);

        [DllImport("dwmapi")]
        private static extern HRESULT DwmUpdateThumbnailProperties(IntPtr hThumbnail, ref DWM_THUMBNAIL_PROPERTIES ptnProperties);

        [DllImport("dwmapi")]
        private static extern HRESULT DwmIsCompositionEnabled(out bool pfEnabled);

        [DllImport("dwmapi")]
        private static extern HRESULT DwmEnableComposition(bool uCompositionAction);
    }
}
