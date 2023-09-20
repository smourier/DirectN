// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSCAMERA_PROFILE_INFO
    {
        public Guid ProfileId;
        public uint Index;
        public uint PinCount;
        public IntPtr Pins;
    }
}
