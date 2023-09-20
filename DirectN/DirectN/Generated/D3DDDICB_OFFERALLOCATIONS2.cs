// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_OFFERALLOCATIONS2
    {
        public IntPtr pResources;
        public IntPtr HandleList;
        public uint NumAllocations;
        public _D3DDDI_OFFER_PRIORITY Priority;
        public D3DDDI_OFFER_FLAGS Flags;
    }
}
