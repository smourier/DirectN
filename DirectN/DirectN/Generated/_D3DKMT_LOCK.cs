// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_LOCK
    {
        public uint hDevice;
        public uint hAllocation;
        public uint PrivateDriverData;
        public uint NumPages;
        public IntPtr pPages;
        public IntPtr pData;
        public _D3DDDICB_LOCKFLAGS Flags;
        public ulong GpuVirtualAddress;
    }
}
