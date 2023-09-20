// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagFONTSIGNATURE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] fsUsb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] fsCsb;
    }
}
