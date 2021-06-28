// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcommon.h(155,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Description of a pixel format.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_PIXEL_FORMAT
    {
        public DXGI_FORMAT format;
        public D2D1_ALPHA_MODE alphaMode;
    }
}
