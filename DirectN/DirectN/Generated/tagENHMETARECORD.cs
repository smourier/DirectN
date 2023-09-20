// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagENHMETARECORD
    {
        public uint iType;
        public uint nSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] dParm;
    }
}
