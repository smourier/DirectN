// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETPALETTE
    {
        public uint VidPnSourceId;
        public uint FirstEntry;
        public uint NumEntries;
        public IntPtr pLookupTable;
    }
}
