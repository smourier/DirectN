// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4751,9)
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
