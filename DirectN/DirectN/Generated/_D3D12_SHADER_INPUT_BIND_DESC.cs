// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12shader.h(146,9)
using System;
using System.Runtime.InteropServices;
using D3D_SHADER_INPUT_TYPE = DirectN._D3D_SHADER_INPUT_TYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_SHADER_INPUT_BIND_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Name;
        public D3D_SHADER_INPUT_TYPE Type;
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
