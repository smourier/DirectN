// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_GETFORMATS = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETMOCOMPFORMATSDATA
    {
        public IntPtr lpDD;
        public IntPtr lpGuid;
        public uint dwNumFormats;
        public IntPtr lpFormats;
        public HRESULT ddRVal;
        public IntPtr GetMoCompFormats;
    }
}
