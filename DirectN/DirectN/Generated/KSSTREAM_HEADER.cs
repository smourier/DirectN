// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ks.h(2072,9)
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
