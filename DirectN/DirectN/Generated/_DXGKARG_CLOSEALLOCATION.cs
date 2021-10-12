// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1243,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CLOSEALLOCATION
    {
        public uint NumAllocations;
        public IntPtr pOpenHandleList;
    }
}
