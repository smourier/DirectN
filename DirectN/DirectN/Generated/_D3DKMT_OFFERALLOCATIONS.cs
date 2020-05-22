// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3546,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OFFERALLOCATIONS
    {
        public uint hDevice;
        public IntPtr pResources;
        public IntPtr HandleList;
        public uint NumAllocations;
        public _D3DKMT_OFFER_PRIORITY Priority;
        public _D3DKMT_OFFER_FLAGS Flags;
    }
}
