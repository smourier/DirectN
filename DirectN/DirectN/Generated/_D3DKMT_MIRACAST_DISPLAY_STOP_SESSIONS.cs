﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4625,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MIRACAST_DISPLAY_STOP_SESSIONS
    {
        public LUID AdapterLuid;
        public uint TargetId;
        public uint StopReason;
    }
}
