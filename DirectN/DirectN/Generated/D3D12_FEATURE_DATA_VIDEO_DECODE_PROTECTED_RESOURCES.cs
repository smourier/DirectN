// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3383,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROTECTED_RESOURCES
    {
        public uint NodeIndex;
        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
        public D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags;
    }
}
