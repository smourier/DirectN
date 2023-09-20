// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
