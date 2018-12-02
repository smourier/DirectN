// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2814,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_GETGUIDS = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETMOCOMPGUIDSDATA
    {
        public IntPtr lpDD;
        public uint dwNumGuids;
        public IntPtr lpGuids;
        public HRESULT ddRVal;
        public IntPtr GetMoCompGuids;
    }
}
