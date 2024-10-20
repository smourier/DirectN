// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRIMARYCONTEXTDATA
    {
        public IntPtr hContext;
        public IntPtr hAllocation;
        public _DXGK_PRIMARYCONTEXTDATA__union_0 __union_2;
        public _DXGK_PRIMARYCONTEXTDATA__union_1 __union_3;
    }
}
