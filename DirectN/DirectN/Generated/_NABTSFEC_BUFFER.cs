// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _NABTSFEC_BUFFER
    {
        public uint dataSize;
        public ushort groupID;
        public ushort Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 448)] 
        public byte[] data;
    }
}
