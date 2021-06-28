// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(7574,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFRR_COMPONENTS
    {
        public uint dwRRInfoVersion;
        public uint dwRRComponents;
        public IntPtr pRRComponents;
    }
}
