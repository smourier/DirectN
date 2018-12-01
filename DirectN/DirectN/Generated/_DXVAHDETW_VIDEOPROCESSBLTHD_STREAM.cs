// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(1083,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSBLTHD_STREAM
    {
        public ulong pObject;
        public ulong pInputSurface;
        public RECT SourceRect;
        public RECT DestinationRect;
        public int InputFormat;
        public _DXVAHD_FRAME_FORMAT FrameFormat;
        public uint ColorSpace;
        public uint StreamNumber;
        public uint OutputIndex;
        public uint InputFrameOrField;
        public uint PastFrames;
        public uint FutureFrames;
    }
}
