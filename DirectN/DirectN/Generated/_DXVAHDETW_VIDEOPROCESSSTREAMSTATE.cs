// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxvahd.h(1062,9)
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
