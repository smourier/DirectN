// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(6607,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSCAMERA_PROFILE_PININFO
    {
        public Guid PinCategory;
        public _KSCAMERA_PROFILE_PININFO__union_0 __union_1;
        public uint MediaInfoCount;
        public IntPtr MediaInfos;
    }
}
