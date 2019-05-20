// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4240,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020
    {
        public Guid DecodeProfile;
        public Guid BitstreamEncryption;
        public D3D12DDI_VIDEO_CODED_INTERLACE_TYPE_0020 InterlaceType;
    }
}
