// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10370,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_COLOR__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr => InteropRuntime.Get<D3D11_VIDEO_COLOR_YCbCrA>(__bits, 0, 128);
        public D3D11_VIDEO_COLOR_RGBA RGBA => InteropRuntime.Get<D3D11_VIDEO_COLOR_RGBA>(__bits, 0, 128);
    }
}
