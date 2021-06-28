// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2752,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DESTROYDDLOCALDATA
    {
        public uint dwFlags;
        public IntPtr pDDLcl;
        public HRESULT ddRVal;
    }
}
