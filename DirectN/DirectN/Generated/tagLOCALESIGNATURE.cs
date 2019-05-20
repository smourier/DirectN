// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(990,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagLOCALESIGNATURE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] lsUsb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] lsCsbDefault;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] lsCsbSupported;
    }
}
