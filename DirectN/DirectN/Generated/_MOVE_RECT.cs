// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfapi.h(1185,9)
using System.Runtime.InteropServices;
using POINT = DirectN.tagPOINT;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MOVE_RECT
    {
        public POINT SourcePoint;
        public RECT DestRect;
    }
}
