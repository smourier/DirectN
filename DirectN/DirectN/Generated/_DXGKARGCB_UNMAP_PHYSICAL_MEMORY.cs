// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_UNMAP_PHYSICAL_MEMORY
    {
        public IntPtr hPhysicalMemoryObject;
        public IntPtr pBaseAddress;
        public IntPtr Size;
    }
}
