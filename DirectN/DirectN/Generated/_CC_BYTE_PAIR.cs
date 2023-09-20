// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _CC_BYTE_PAIR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Decoded;
        public ushort Reserved;
    }
}
