// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(373,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTBANDWIDTH
    {
        public uint dwSize;
        public uint dwCaps;
        public uint dwOverlay;
        public uint dwColorkey;
        public uint dwYInterpolate;
        public uint dwYInterpAndColorkey;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
    }
}
