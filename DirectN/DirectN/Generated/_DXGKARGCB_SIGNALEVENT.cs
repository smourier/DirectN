// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_SIGNALEVENT
    {
        public IntPtr hDxgkProcess;
        public IntPtr hEvent;
        public _DXGKARGCB_SIGNALEVENT__union_0 __union_2;
    }
}
