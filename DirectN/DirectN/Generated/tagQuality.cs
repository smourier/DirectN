// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagQuality
    {
        public tagQualityMessageType Type;
        public int Proportion;
        public long Late;
        public long TimeStamp;
    }
}
