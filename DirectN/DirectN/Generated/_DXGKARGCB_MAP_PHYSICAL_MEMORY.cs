// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9470,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_MAP_PHYSICAL_MEMORY
    {
        public IntPtr hPhysicalMemoryObject;
        public _DXGK_ACCESS_MODE AccessMode;
        public IntPtr Offset;
        public IntPtr Size;
        public IntPtr pMappedAddress;
    }
}
