// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1476,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DESTROYALLOCATION2
    {
        public uint hDevice;
        public uint hResource;
        public IntPtr phAllocationList;
        public uint AllocationCount;
        public _D3DDDICB_DESTROYALLOCATION2FLAGS Flags;
    }
}
