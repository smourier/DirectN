// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATSTICS_TERMINATIONS
    {
        public _D3DKMT_QUERYSTATISTICS_COUNTER TerminatedShared;
        public _D3DKMT_QUERYSTATISTICS_COUNTER TerminatedNonShared;
        public _D3DKMT_QUERYSTATISTICS_COUNTER DestroyedShared;
        public _D3DKMT_QUERYSTATISTICS_COUNTER DestroyedNonShared;
    }
}
