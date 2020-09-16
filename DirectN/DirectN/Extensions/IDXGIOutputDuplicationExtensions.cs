using System;

namespace DirectN
{
    public static class IDXGIOutputDuplicationExtensions
    {
        public static DXGI_OUTDUPL_DESC GetDesc(this IComObject<IDXGIOutputDuplication> output) => GetDesc(output?.Object);
        public static DXGI_OUTDUPL_DESC GetDesc(this IDXGIOutputDuplication duplication)
        {
            if (duplication == null)
                throw new ArgumentNullException(nameof(duplication));

            var desc = new DXGI_OUTDUPL_DESC();
            duplication.GetDesc(out desc);
            return desc;
        }
    }
}
