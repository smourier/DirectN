// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
