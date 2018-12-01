// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfapi.h(1612,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagFaceRectInfo
    {
        public RECT Region;
        public int confidenceLevel;
    }
}
