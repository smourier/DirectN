// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4185,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETQUEUEDLIMIT
    {
        public uint hDevice;
        public _D3DKMT_QUEUEDLIMIT_TYPE Type;
        public _D3DKMT_SETQUEUEDLIMIT__union_0 __union_2;
    }
}
