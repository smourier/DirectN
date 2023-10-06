// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_SHADER_RESOURCE_VIEW_0002__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDIARG_BUFFER_SHADER_RESOURCE_VIEW Buffer {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_BUFFER_SHADER_RESOURCE_VIEW>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_BUFFER_SHADER_RESOURCE_VIEW>(value, __bits, 0, 192); } }
        public D3D12DDIARG_TEX1D_SHADER_RESOURCE_VIEW Tex1D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX1D_SHADER_RESOURCE_VIEW>(__bits, 0, 160);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_TEX1D_SHADER_RESOURCE_VIEW>(value, __bits, 0, 160); } }
        public D3D12DDIARG_TEX2D_SHADER_RESOURCE_VIEW_0002 Tex2D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX2D_SHADER_RESOURCE_VIEW_0002>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_TEX2D_SHADER_RESOURCE_VIEW_0002>(value, __bits, 0, 192); } }
        public D3D12DDIARG_TEX3D_SHADER_RESOURCE_VIEW Tex3D {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEX3D_SHADER_RESOURCE_VIEW>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_TEX3D_SHADER_RESOURCE_VIEW>(value, __bits, 0, 96); } }
        public D3D12DDIARG_TEXCUBE_SHADER_RESOURCE_VIEW TexCube {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_TEXCUBE_SHADER_RESOURCE_VIEW>(__bits, 0, 160);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_TEXCUBE_SHADER_RESOURCE_VIEW>(value, __bits, 0, 160); } }
        public D3D12DDIARG_RAYTRACING_ACCELERATION_STRUCTURE_SHADER_RESOURCE_VIEW_0042 RaytracingAccelerationStructure {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D12DDIARG_RAYTRACING_ACCELERATION_STRUCTURE_SHADER_RESOURCE_VIEW_0042>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<D3D12DDIARG_RAYTRACING_ACCELERATION_STRUCTURE_SHADER_RESOURCE_VIEW_0042>(value, __bits, 0, 64); } }
    }
}
