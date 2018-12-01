// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(281,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_CONTENT_DESC
    {
        public _DXVAHD_FRAME_FORMAT InputFrameFormat;
        public _DXVAHD_RATIONAL InputFrameRate;
        public uint InputWidth;
        public uint InputHeight;
        public _DXVAHD_RATIONAL OutputFrameRate;
        public uint OutputWidth;
        public uint OutputHeight;
    }
}
