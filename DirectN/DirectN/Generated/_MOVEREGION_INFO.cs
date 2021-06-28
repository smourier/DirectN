// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfapi.h(1198,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MOVEREGION_INFO
    {
        public uint FrameNumber;
        public uint NumMoveRegions;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MOVE_RECT[] MoveRegions;
    }
}
