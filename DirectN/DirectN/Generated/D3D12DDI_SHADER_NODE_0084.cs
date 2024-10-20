// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SHADER_NODE_0084
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Shader;
        public D3D12DDI_NODE_PROPERTIES_TYPE_0084 PropertiesType;
        public D3D12DDI_SHADER_NODE_0084__union_0 __union_2;
    }
}
