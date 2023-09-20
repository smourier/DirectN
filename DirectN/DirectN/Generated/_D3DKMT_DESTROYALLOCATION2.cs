// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
