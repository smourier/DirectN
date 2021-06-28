// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1605,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct INTERLEAVED_AUDIO_FORMAT_INFORMATION
    {
        public uint Size;
        public uint PrimaryChannelCount;
        public uint PrimaryChannelStartPosition;
        public uint PrimaryChannelMask;
        public uint InterleavedChannelCount;
        public uint InterleavedChannelStartPosition;
        public uint InterleavedChannelMask;
    }
}
