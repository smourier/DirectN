// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4742,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_EVICT
    {
        public uint hDevice;
        public uint NumAllocations;
        public IntPtr AllocationList;
        public D3DDDI_EVICT_FLAGS Flags;
        public ulong NumBytesToTrim;
    }
}
