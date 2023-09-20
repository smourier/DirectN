// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _NABTS_BUFFER_LINE
    {
        public byte Confidence;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)] 
        public byte[] Bytes;
    }
}
