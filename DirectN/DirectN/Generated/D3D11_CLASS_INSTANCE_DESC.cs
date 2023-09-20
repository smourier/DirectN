// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_CLASS_INSTANCE_DESC
    {
        public uint InstanceId;
        public uint InstanceIndex;
        public uint TypeId;
        public uint ConstantBuffer;
        public uint BaseConstantBufferOffset;
        public uint BaseTexture;
        public uint BaseSampler;
        public bool Created;
    }
}
