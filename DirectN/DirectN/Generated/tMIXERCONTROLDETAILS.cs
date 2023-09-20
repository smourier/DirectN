// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tMIXERCONTROLDETAILS
    {
        public uint cbStruct;
        public uint dwControlID;
        public uint cChannels;
        public tMIXERCONTROLDETAILS__union_0 __union_3;
        public uint cbDetails;
        public IntPtr paDetails;
    }
}
