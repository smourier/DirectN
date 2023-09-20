// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_CRYPTO_SESSION_SUPPORT_DATA_0030
    {
        public uint NodeIndex;
        public Guid DecodeProfile;
        public Guid ContentProtectionSystem;
        public D3D12DDI_CRYPTO_SESSION_FLAGS_0030 Flags;
        public D3D12DDI_BITSTREAM_ENCRYPTION_TYPE_0030 BitstreamEncryption;
        public uint KeyBaseDataSize;
        public D3D12DDI_CRYPTO_SESSION_SUPPORT_FLAGS_0030 Support;
    }
}
