// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddkmapi.h(135,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENVIDEOPORTOUT
    {
        public uint ddRVal;
        public IntPtr hVideoPort;
    }
}
