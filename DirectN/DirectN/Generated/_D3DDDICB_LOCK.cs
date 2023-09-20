// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_LOCK
    {
        public uint hAllocation;
        public uint PrivateDriverData;
        public uint NumPages;
        public IntPtr pPages;
        public IntPtr pData;
        public _D3DDDICB_LOCKFLAGS Flags;
        public ulong GpuVirtualAddress;
    }
}
