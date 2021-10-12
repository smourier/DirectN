// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9506,9)
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
