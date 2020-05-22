// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(4348,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDESIGNVECTOR
    {
        public uint dvReserved;
        public uint dvNumAxes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public int[] dvValues;
    }
}
