// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3965,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS
    {
        public _D3DKMT_QUERYSTATISTICS_TYPE Type;
        public LUID AdapterLuid;
        public IntPtr hProcess;
        public _D3DKMT_QUERYSTATISTICS_RESULT QueryResult;
        public _D3DKMT_QUERYSTATISTICS__union_0 __union_4;
    }
}
