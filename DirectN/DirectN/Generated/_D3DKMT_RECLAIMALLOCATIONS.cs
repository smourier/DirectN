// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_RECLAIMALLOCATIONS
    {
        public uint hDevice;
        public IntPtr pResources;
        public IntPtr HandleList;
        public IntPtr pDiscarded;
        public uint NumAllocations;
    }
}
