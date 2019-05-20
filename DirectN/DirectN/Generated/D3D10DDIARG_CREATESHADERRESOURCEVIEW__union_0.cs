// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(573,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_CREATESHADERRESOURCEVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW Buffer { get => InteropRuntime.Get<D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW>(__bits, 0, 64); set => InteropRuntime.Set<D3D10DDIARG_BUFFER_SHADERRESOURCEVIEW>(value, __bits, 0, 64); }
        public D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW Tex1D { get => InteropRuntime.Get<D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW>(__bits, 0, 128); set => InteropRuntime.Set<D3D10DDIARG_TEX1D_SHADERRESOURCEVIEW>(value, __bits, 0, 128); }
        public D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW Tex2D { get => InteropRuntime.Get<D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW>(__bits, 0, 128); set => InteropRuntime.Set<D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW>(value, __bits, 0, 128); }
        public D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW Tex3D { get => InteropRuntime.Get<D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW>(__bits, 0, 64); set => InteropRuntime.Set<D3D10DDIARG_TEX3D_SHADERRESOURCEVIEW>(value, __bits, 0, 64); }
        public D3D10DDIARG_TEXCUBE_SHADERRESOURCEVIEW TexCube { get => InteropRuntime.Get<D3D10DDIARG_TEXCUBE_SHADERRESOURCEVIEW>(__bits, 0, 64); set => InteropRuntime.Set<D3D10DDIARG_TEXCUBE_SHADERRESOURCEVIEW>(value, __bits, 0, 64); }
    }
}
