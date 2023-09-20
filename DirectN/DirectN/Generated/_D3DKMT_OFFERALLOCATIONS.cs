// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
