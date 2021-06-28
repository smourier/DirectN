// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(11375,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_TEX2D_VPIV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_VPIV>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<D3D11_TEX2D_VPIV>(value, __bits, 0, 64); } }
    }
}
