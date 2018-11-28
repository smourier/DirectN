using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_PIXEL_FORMAT
    {
        public DXGI_FORMAT format;
        public D2D1_ALPHA_MODE alphaMode;
    }
}
