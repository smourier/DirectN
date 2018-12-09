// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(6581,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSDEVICE_PROFILE_INFO__union_0__struct_0
    {
        public _KSCAMERA_PROFILE_INFO Info;
        public uint Reserved;
        public uint ConcurrencyCount;
        public IntPtr Concurrency;
    }
}
