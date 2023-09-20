// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER_PROPERTY
    {
        public KSIDENTIFIER Property;
        public IntPtr BaseAddress;
        public uint RequestedBufferSize;
    }
}
