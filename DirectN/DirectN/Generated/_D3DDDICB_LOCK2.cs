// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_LOCK2
    {
        public uint hAllocation;
        public _D3DDDICB_LOCK2FLAGS Flags;
        public IntPtr pData;
    }
}
