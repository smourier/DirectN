// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(1651,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_INT = DirectN._DDRAWI_DIRECTDRAW_INT;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DIRECTDRAW_INT
    {
        public IntPtr lpVtbl;
        public IntPtr lpLcl;
        public IntPtr lpLink;
        public uint dwIntRefCnt;
    }
}
