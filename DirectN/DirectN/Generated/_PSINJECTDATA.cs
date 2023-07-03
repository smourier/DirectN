// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(425,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _PSINJECTDATA
    {
        public uint DataBytes;
        public ushort InjectionPoint;
        public ushort PageNumber;
    }
}
