// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2521,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETVPORTCONNECT = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTCONNECT = DirectN._DDVIDEOPORTCONNECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTCONNECTDATA
    {
        public IntPtr lpDD;
        public uint dwPortId;
        public IntPtr lpConnect;
        public uint dwNumEntries;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortConnectInfo;
    }
}
