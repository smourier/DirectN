// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(813,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDGAMMARAMP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] blue;
    }
}
