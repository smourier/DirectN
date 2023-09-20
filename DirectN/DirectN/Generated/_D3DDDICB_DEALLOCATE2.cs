// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_DEALLOCATE2
    {
        public IntPtr hResource;
        public uint NumAllocations;
        public IntPtr HandleList;
        public _D3DDDICB_DESTROYALLOCATION2FLAGS Flags;
    }
}
