// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4337,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CONTENT_PROTECTION_DRM_SUPPORT_DATA_0020
    {
        public Guid DecodeProfile;
        public Guid ContentProtectionSystem;
        public uint PrependInputDataSize;
        public uint PrependOutputDataSize;
        public uint HardwareKeyDataDataSize;
        public bool fSupported;
    }
}
