// generated from <Windows SDK Path>\um\dxvahd.h
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
