// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(11562,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] __bits;
        public D3D11_TEX2D_VPOV Texture2D => InteropRuntime.Get<D3D11_TEX2D_VPOV>(__bits, 0, 32);
        public D3D11_TEX2D_ARRAY_VPOV Texture2DArray => InteropRuntime.Get<D3D11_TEX2D_ARRAY_VPOV>(__bits, 0, 96);
    }
}
