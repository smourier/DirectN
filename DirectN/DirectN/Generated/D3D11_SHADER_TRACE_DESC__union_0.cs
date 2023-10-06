// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_TRACE_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_VERTEX_SHADER_TRACE_DESC>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_VERTEX_SHADER_TRACE_DESC>(value, __bits, 0, 64); } }
        public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_HULL_SHADER_TRACE_DESC>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_HULL_SHADER_TRACE_DESC>(value, __bits, 0, 64); } }
        public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_DOMAIN_SHADER_TRACE_DESC>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_DOMAIN_SHADER_TRACE_DESC>(value, __bits, 0, 64); } }
        public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_GEOMETRY_SHADER_TRACE_DESC>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_GEOMETRY_SHADER_TRACE_DESC>(value, __bits, 0, 64); } }
        public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_PIXEL_SHADER_TRACE_DESC>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_PIXEL_SHADER_TRACE_DESC>(value, __bits, 0, 192); } }
        public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3D11_COMPUTE_SHADER_TRACE_DESC>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D11_COMPUTE_SHADER_TRACE_DESC>(value, __bits, 0, 256); } }
    }
}
