// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(11226,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public D3D11_TEX2D_VDOV Texture2D => InteropRuntime.GetBits<D3D11_TEX2D_VDOV>(__bits, 0, 32);
    }
}
