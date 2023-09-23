// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;
using D3DCOLOR = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_STATE_PALETTE_DATA
    {
        public uint Count;
        public IntPtr pEntries;
    }
}
