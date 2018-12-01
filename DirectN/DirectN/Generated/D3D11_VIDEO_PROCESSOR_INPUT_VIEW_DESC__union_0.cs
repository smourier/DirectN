// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(11391,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public D3D11_TEX2D_VPIV Texture2D => InteropRuntime.GetBits<D3D11_TEX2D_VPIV>(__bits, 0, 64);
    }
}
