// generated from <Windows SDK Path>\um\wmsdkidl.h
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
