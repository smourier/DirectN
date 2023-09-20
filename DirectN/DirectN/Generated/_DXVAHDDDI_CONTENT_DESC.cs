// generated from <Windows SDK Path>\um\d3dumddi.h
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
