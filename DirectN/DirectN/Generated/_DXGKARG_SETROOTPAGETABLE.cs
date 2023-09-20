// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETROOTPAGETABLE
    {
        public IntPtr hContext;
        public _D3DGPU_PHYSICAL_ADDRESS Address;
        public uint NumEntries;
    }
}
