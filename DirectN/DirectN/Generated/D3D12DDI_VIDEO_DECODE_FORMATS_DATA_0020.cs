// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4262,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_FORMATS_DATA_0020
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration;
        public uint FormatCount;
        public IntPtr pOutputFormats;
    }
}
