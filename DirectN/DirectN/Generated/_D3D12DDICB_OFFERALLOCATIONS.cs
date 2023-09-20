// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12DDICB_OFFERALLOCATIONS
    {
        public uint NumAllocations;
        public IntPtr HandleList;
        public _D3DDDI_OFFER_PRIORITY Priority;
    }
}
