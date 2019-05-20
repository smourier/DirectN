// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2546,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_CONTENT_DESC
    {
        public _DXVAHDDDI_FRAME_FORMAT InputFrameFormat;
        public _DXVAHDDDI_RATIONAL InputFrameRate;
        public uint InputWidth;
        public uint InputHeight;
        public _DXVAHDDDI_RATIONAL OutputFrameRate;
        public uint OutputWidth;
        public uint OutputHeight;
    }
}
