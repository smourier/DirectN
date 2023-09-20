// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_INPUT_BIND_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public _D3D_SHADER_INPUT_TYPE Type;
        public uint BindPoint;
        public uint BindCount;
        public uint uFlags;
        public D3D_RESOURCE_RETURN_TYPE ReturnType;
        public D3D_SRV_DIMENSION Dimension;
        public uint NumSamples;
        public uint Space;
        public uint uID;
    }
}
