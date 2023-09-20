// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSSTREAMSTATE
    {
        public ulong pObject;
        public uint StreamNumber;
        public _DXVAHD_STREAM_STATE State;
        public uint DataSize;
        public bool SetState;
    }
}
