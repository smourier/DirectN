// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct DD32BITDRIVERDATA
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string szName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szEntryPoint;
        public uint dwContext;
    }
}
