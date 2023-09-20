// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROOT_PARAMETER
    {
        public D3D12DDI_ROOT_PARAMETER_TYPE ParameterType;
        public D3D12DDI_ROOT_PARAMETER__union_0 __union_1;
        public D3D12DDI_SHADER_VISIBILITY ShaderVisibility;
    }
}
