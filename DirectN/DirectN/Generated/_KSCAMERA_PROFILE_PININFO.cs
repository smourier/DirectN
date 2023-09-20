// generated from <Windows SDK Path>\shared\ksmedia.h
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
