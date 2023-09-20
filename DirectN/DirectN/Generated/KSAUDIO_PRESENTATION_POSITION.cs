// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_PRESENTATION_POSITION
    {
        public ulong u64PositionInBlocks;
        public ulong u64QPCPosition;
    }
}
