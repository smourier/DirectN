// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAM_HEADER
    {
        public uint Size;
        public uint TypeSpecificFlags;
        public KSTIME PresentationTime;
        public long Duration;
        public uint FrameExtent;
        public uint DataUsed;
        public IntPtr Data;
        public uint OptionsFlags;
        public uint Reserved;
    }
}
