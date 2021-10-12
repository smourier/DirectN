// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9604,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_PINFRAMEBUFFERFORSAVE2
    {
        public uint PhysicalAdapterIndex;
        public IntPtr CommitSize;
        public _DXGKARGCB_PINFRAMEBUFFERFORSAVE2__union_0 Flags;
        public IntPtr pAdl;
    }
}
