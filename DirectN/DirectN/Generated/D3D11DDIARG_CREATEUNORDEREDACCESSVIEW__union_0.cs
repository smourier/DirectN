// generated from <Windows SDK Path>\um\d3d10umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEUNORDEREDACCESSVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW Tex1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW Tex2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW Tex3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
    }
}
