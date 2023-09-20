// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_ATR
    {
        public uint ulCAT;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 768)] 
        public byte[] pbATRI;
    }
}
