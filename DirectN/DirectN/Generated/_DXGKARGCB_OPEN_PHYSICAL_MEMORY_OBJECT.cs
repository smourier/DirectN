// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9550,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_OPEN_PHYSICAL_MEMORY_OBJECT
    {
        public IntPtr hPhysicalMemoryObject;
        public IntPtr hAdapter;
        public IntPtr hAdapterMemoryObject;
    }
}
