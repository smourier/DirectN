// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxvahd.h(1054,9)
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
