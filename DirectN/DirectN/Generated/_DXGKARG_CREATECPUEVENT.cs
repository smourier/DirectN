// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(954,9)
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
