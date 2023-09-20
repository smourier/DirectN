// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SECURE_BUFFER_INFO
    {
        public Guid guidBufferIdentifier;
        public uint cbBufferSize;
        public uint cbCaptured;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public ulong[] ullReserved;
    }
}
