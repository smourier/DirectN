// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(10762,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_COLOR__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr { get => InteropRuntime.Get<D3D11_VIDEO_COLOR_YCbCrA>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_VIDEO_COLOR_YCbCrA>(value, __bits, 0, 128); } }
        public D3D11_VIDEO_COLOR_RGBA RGBA { get => InteropRuntime.Get<D3D11_VIDEO_COLOR_RGBA>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<D3D11_VIDEO_COLOR_RGBA>(value, __bits, 0, 128); } }
    }
}
