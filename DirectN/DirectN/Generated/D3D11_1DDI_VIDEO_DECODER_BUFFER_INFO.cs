// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3114,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_DECODER_BUFFER_INFO
    {
        public D3D11_DDI_VIDEO_DECODER_BUFFER_TYPE Type;
        public uint Size;
        public uint Usage;
    }
}
