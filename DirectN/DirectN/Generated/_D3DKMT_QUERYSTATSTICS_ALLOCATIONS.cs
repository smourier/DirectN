// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3401,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_ALLOCATIONS
    {
        public _D3DKMT_QUERYSTATISTICS_COUNTER Created;
        public _D3DKMT_QUERYSTATISTICS_COUNTER Destroyed;
        public _D3DKMT_QUERYSTATISTICS_COUNTER Opened;
        public _D3DKMT_QUERYSTATISTICS_COUNTER Closed;
        public _D3DKMT_QUERYSTATISTICS_COUNTER MigratedSuccess;
        public _D3DKMT_QUERYSTATISTICS_COUNTER MigratedFail;
        public _D3DKMT_QUERYSTATISTICS_COUNTER MigratedAbandoned;
    }
}
