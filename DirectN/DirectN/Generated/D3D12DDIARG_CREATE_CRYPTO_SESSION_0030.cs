// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(8939,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_CRYPTO_SESSION_0030
    {
        public uint NodeMask;
        public Guid DecodeProfile;
        public Guid ContentProtectionSystem;
        public D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption;
        public D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags;
    }
}
