// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATECPUEVENT
    {
        public IntPtr hKmdDevice;
        public IntPtr hDxgCpuEvent;
        public _DXGK_CREATECPUEVENTFLAGS Flags;
        public IntPtr hKmdCpuEvent;
    }
}
