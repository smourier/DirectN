// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct tagMIXERCONTROLDETAILS_LISTTEXTA
    {
        public uint dwParam1;
        public uint dwParam2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string szName;
    }
}
