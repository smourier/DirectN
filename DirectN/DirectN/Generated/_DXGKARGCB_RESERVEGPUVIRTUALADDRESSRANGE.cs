// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_RESERVEGPUVIRTUALADDRESSRANGE
    {
        public IntPtr hDxgkProcess;
        public ulong SizeInBytes;
        public uint Alignment;
        public ulong StartVirtualAddress;
        public ulong BaseAddress;
        public _DXGKARGCB_RESERVEGPUVIRTUALADDRESSRANGE__union_0 __union_5;
    }
}
