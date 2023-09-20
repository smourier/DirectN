// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_LOCK2
    {
        public uint hDevice;
        public uint hAllocation;
        public _D3DDDICB_LOCK2FLAGS Flags;
        public IntPtr pData;
    }
}
