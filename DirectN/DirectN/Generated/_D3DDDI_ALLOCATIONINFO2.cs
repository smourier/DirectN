// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(320,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ALLOCATIONINFO2
    {
        public uint hAllocation;
        public _D3DDDI_ALLOCATIONINFO2__union_0 __union_1;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint VidPnSourceId;
        public _D3DDDI_ALLOCATIONINFO2__union_1 Flags;
        public ulong GpuVirtualAddress;
        public _D3DDDI_ALLOCATIONINFO2__union_2 __union_7;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public IntPtr[] Reserved;
    }
}
