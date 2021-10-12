// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_RESERVEGPUVIRTUALADDRESSRANGE
    {
        public IntPtr hDxgkProcess;
        public ulong SizeInBytes;
        public uint Alignment;
        public ulong StartVirtualAddress;
        public ulong BaseAddress;
        public _DXGKARGCB_RESERVEGPUVIRTUALADDRESSRANGE__union_0 __union_5;
    }
}
