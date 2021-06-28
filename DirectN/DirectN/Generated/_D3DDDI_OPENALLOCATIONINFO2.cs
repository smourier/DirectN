// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(378,9)
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
