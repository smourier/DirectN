// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4102,9)
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
