// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_RENAME
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public IntPtr hCookie;
        public ulong GpuVirtualAddress;
    }
}
