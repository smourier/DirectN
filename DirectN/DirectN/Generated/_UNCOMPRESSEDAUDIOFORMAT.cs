// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audiomediatype.h(67,9)
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
