// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;
using DMUS_CLOCKTYPE = DirectN.DMUS_CLOCK;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _DMUS_CLOCKINFO8
    {
        public uint dwSize;
        public DMUS_CLOCKTYPE ctType;
        public Guid guidClock;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string wszDescription;
        public uint dwFlags;
    }
}
