// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAXESLISTW
    {
        public uint axlReserved;
        public uint axlNumAxes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public tagAXISINFOW[] axlAxisInfo;
    }
}
