// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SYNCTOKEN
    {
        public IntPtr hSyncToken;
        public uint BroadcastContextCount;
        public IntPtr BroadcastContextArray;
    }
}
