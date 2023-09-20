// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERLINEA
    {
        public uint cbStruct;
        public uint dwDestination;
        public uint dwSource;
        public uint dwLineID;
        public uint fdwLine;
        public IntPtr dwUser;
        public uint dwComponentType;
        public uint cChannels;
        public uint cConnections;
        public uint cControls;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string szShortName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
        public tagMIXERLINEA__struct_0 Target;
    }
}
