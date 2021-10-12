// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(961,9)
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
