// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(720,9)
using System.Runtime.InteropServices;
using D3DRENDERSTATETYPE = DirectN._D3DRENDERSTATETYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2RENDERSTATE
    {
        public D3DRENDERSTATETYPE RenderState;
        public _D3DNTHAL_DP2RENDERSTATE__union_0 __union_1;
    }
}
