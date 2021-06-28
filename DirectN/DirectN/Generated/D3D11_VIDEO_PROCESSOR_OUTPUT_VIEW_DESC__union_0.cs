// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(11546,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_TEX2D_VPOV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_VPOV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_VPOV>(value, __bits, 0, 32); } }
        public D3D11_TEX2D_ARRAY_VPOV Texture2DArray { get => InteropRuntime.Get<D3D11_TEX2D_ARRAY_VPOV>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11_TEX2D_ARRAY_VPOV>(value, __bits, 0, 96); } }
    }
}
