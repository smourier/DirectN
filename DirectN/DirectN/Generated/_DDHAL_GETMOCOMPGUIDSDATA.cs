// generated from <Windows SDK Path>\um\ddrawi.h
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
