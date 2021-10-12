// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkernel.h(113,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDKERNELCAPS
    {
        public uint dwSize;
        public uint dwCaps;
        public uint dwIRQCaps;
    }
}
