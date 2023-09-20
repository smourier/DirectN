// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER
    {
        public IntPtr BufferAddress;
        public uint ActualBufferSize;
        public bool CallMemoryBarrier;
    }
}
