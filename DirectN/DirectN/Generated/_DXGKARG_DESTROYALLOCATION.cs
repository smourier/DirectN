// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_DESTROYALLOCATION
    {
        public uint NumAllocations;
        public IntPtr pAllocationList;
        public IntPtr hResource;
        public _DXGK_DESTROYALLOCATIONFLAGS Flags;
    }
}
