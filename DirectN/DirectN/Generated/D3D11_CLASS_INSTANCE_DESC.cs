// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7016,9)
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
