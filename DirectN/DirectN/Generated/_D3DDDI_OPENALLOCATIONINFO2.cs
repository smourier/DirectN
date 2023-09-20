// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_OPENALLOCATIONINFO2
    {
        public uint hAllocation;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public ulong GpuVirtualAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public IntPtr[] Reserved;
    }
}
