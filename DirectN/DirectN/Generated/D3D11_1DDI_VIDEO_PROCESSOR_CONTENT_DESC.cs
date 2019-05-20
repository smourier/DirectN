// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3191,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_CONTENT_DESC
    {
        public D3D11_1DDI_VIDEO_FRAME_FORMAT InputFrameFormat;
        public int InputFrameRate;
        public uint InputWidth;
        public uint InputHeight;
        public int OutputFrameRate;
        public uint OutputWidth;
        public uint OutputHeight;
        public D3D11_1DDI_VIDEO_USAGE Usage;
    }
}
