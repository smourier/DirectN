// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SHADER_NODE
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Shader;
        public D3D12_NODE_OVERRIDES_TYPE OverridesType;
        public D3D12_SHADER_NODE__union_0 __union_2;
    }
}
