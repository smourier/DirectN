// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_FLUSHHWQUEUE
    {
        public IntPtr hHwQueue;
        public IntPtr Event;
        public _DXGKARG_FLUSHHWQUEUE_FLAGS Flags;
    }
}
