// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSBLTSTATE
    {
        public ulong pObject;
        public _DXVAHD_BLT_STATE State;
        public uint DataSize;
        public bool SetState;
    }
}
