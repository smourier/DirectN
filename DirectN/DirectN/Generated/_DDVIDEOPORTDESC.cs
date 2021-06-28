// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(333,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTDESC
    {
        public uint dwSize;
        public uint dwFieldWidth;
        public uint dwVBIWidth;
        public uint dwFieldHeight;
        public uint dwMicrosecondsPerField;
        public uint dwMaxPixelsPerSecond;
        public uint dwVideoPortID;
        public uint dwReserved1;
        public _DDVIDEOPORTCONNECT VideoPortType;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
    }
}
