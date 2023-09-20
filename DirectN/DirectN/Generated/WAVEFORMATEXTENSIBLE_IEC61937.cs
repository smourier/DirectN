// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WAVEFORMATEXTENSIBLE_IEC61937
    {
        public WAVEFORMATEXTENSIBLE FormatExt;
        public uint dwEncodedSamplesPerSec;
        public uint dwEncodedChannelCount;
        public uint dwAverageBytesPerSec;
    }
}
