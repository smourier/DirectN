// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2826,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDSCH_ESCAPE
    {
        public _D3DKMT_VIDSCHESCAPETYPE Type;
        public _D3DKMT_VIDSCH_ESCAPE__union_0 __union_1;
        public _D3DKMT_ESCAPE_VIRTUAL_REFRESH_RATE VirtualRefreshRateControl;
    }
}
