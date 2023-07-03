// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(212,9)
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
