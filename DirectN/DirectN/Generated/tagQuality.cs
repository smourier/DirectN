// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(5676,9)
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
