using System;

namespace DirectN
{
    public static class IDXGIOutputDuplicationExtensions
    {
        public static DXGI_OUTDUPL_DESC GetDesc(this ComObject<IDXGIOutputDuplication> output) => GetDesc(output?.Object);
        public static DXGI_OUTDUPL_DESC GetDesc(this IDXGIOutputDuplication duplication)
        {
            if (duplication == null)
                throw new ArgumentNullException(nameof(duplication));

#pragma warning disable CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            duplication.GetDesc(out var desc);
#pragma warning restore CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            return desc;
        }
    }
}
