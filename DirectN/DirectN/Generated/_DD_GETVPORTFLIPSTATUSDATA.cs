﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1574,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETVPORTFLIPSTATUSDATA
    {
        public IntPtr lpDD;
        public ulong fpSurface;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortFlipStatus;
    }
}
