// generated from <Windows SDK Path>\um\audiomediatype.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _UNCOMPRESSEDAUDIOFORMAT
    {
        public Guid guidFormatType;
        public uint dwSamplesPerFrame;
        public uint dwBytesPerSampleContainer;
        public uint dwValidBitsPerSample;
        public float fFramesPerSecond;
        public uint dwChannelMask;
    }
}
