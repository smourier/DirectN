// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(204,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_UNLOCK
    {
        public uint hDevice;
        public uint NumAllocations;
        public IntPtr phAllocations;
    }
}
