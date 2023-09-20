// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRVideoDesc
    {
        public uint dwSize;
        public uint dwSampleWidth;
        public uint dwSampleHeight;
        public bool SingleFieldPerSample;
        public uint dwFourCC;
        public _VMRFrequency InputSampleFreq;
        public _VMRFrequency OutputFrameFreq;
    }
}
