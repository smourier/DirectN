// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3550,9)
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
