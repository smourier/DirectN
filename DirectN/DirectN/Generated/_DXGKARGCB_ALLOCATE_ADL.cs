// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ALLOCATE_ADL
    {
        public IntPtr hAdapterMemoryObject;
        public IntPtr Offset;
        public IntPtr Size;
        public _DXGKARGCB_ALLOCATE_ADL__union_0 Flags;
        public IntPtr pAdl;
    }
}
