// generated from <Windows SDK Path>\um\d3d11.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_TEX2D_VDOV Texture2D { get => InteropRuntime.Get<D3D11_TEX2D_VDOV>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<D3D11_TEX2D_VDOV>(value, __bits, 0, 32); } }
    }
}
