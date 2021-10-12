// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5272,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_COLLECTDBGINFO
    {
        public uint Reason;
        public IntPtr pBuffer;
        public IntPtr BufferSize;
        public IntPtr pExtension;
    }
}
