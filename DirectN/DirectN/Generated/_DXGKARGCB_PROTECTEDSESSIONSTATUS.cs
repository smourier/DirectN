﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8862,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_PROTECTEDSESSIONSTATUS
    {
        public IntPtr hProtectedSession;
        public _DXGK_PROTECTED_SESSION_STATUS Status;
    }
}
