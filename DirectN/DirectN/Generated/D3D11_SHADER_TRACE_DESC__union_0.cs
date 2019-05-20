// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(126,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_TRACE_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11_VERTEX_SHADER_TRACE_DESC VertexShaderTraceDesc { get => InteropRuntime.Get<D3D11_VERTEX_SHADER_TRACE_DESC>(__bits, 0, 64); set => InteropRuntime.Set<D3D11_VERTEX_SHADER_TRACE_DESC>(value, __bits, 0, 64); }
        public D3D11_HULL_SHADER_TRACE_DESC HullShaderTraceDesc { get => InteropRuntime.Get<D3D11_HULL_SHADER_TRACE_DESC>(__bits, 0, 64); set => InteropRuntime.Set<D3D11_HULL_SHADER_TRACE_DESC>(value, __bits, 0, 64); }
        public D3D11_DOMAIN_SHADER_TRACE_DESC DomainShaderTraceDesc { get => InteropRuntime.Get<D3D11_DOMAIN_SHADER_TRACE_DESC>(__bits, 0, 64); set => InteropRuntime.Set<D3D11_DOMAIN_SHADER_TRACE_DESC>(value, __bits, 0, 64); }
        public D3D11_GEOMETRY_SHADER_TRACE_DESC GeometryShaderTraceDesc { get => InteropRuntime.Get<D3D11_GEOMETRY_SHADER_TRACE_DESC>(__bits, 0, 64); set => InteropRuntime.Set<D3D11_GEOMETRY_SHADER_TRACE_DESC>(value, __bits, 0, 64); }
        public D3D11_PIXEL_SHADER_TRACE_DESC PixelShaderTraceDesc { get => InteropRuntime.Get<D3D11_PIXEL_SHADER_TRACE_DESC>(__bits, 0, 192); set => InteropRuntime.Set<D3D11_PIXEL_SHADER_TRACE_DESC>(value, __bits, 0, 192); }
        public D3D11_COMPUTE_SHADER_TRACE_DESC ComputeShaderTraceDesc { get => InteropRuntime.Get<D3D11_COMPUTE_SHADER_TRACE_DESC>(__bits, 0, 320); set => InteropRuntime.Set<D3D11_COMPUTE_SHADER_TRACE_DESC>(value, __bits, 0, 320); }
    }
}
