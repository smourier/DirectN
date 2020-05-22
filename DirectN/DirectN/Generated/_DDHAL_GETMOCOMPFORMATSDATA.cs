// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2826,9)
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
