// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSCAMERA_PROFILE_CONCURRENCYINFO
    {
        public Guid ReferenceGuid;
        public uint Reserved;
        public uint ProfileCount;
        public IntPtr Profiles;
    }
}
