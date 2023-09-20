// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_RECLAIMALLOCATIONS
    {
        public IntPtr pResources;
        public IntPtr HandleList;
        public IntPtr pDiscarded;
        public uint NumAllocations;
    }
}
