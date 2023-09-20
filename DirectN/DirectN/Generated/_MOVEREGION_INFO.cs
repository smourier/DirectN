// generated from <Windows SDK Path>\um\mfapi.h
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
