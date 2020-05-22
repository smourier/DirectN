// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(2068,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _WMT_TIMECODE_EXTENSION_DATA
    {
        public ushort wRange;
        public uint dwTimecode;
        public uint dwUserbits;
        public uint dwAmFlags;
    }
}
