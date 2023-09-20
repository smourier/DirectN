// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct midievent_tag
    {
        public uint dwDeltaTime;
        public uint dwStreamID;
        public uint dwEvent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] dwParms;
    }
}
