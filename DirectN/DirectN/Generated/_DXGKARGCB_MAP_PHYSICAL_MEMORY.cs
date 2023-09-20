// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
