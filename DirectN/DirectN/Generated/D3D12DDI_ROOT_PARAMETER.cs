// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1317,9)
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
