// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_DVDCOPY_CHLGKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] 
        public byte[] ChlgKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved;
    }
}
