// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSCAMERA_PERFRAMESETTING_HEADER
    {
        public uint Size;
        public uint FrameCount;
        public Guid Id;
        public ulong Flags;
        public uint LoopCount;
        public uint Reserved;
    }
}
