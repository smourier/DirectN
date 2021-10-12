// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(1131,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWPALETTE_INT = DirectN._DDRAWI_DDRAWPALETTE_INT;
using LPDDRAWI_DDRAWPALETTE_LCL = DirectN._DDRAWI_DDRAWPALETTE_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWPALETTE_INT
    {
        public IntPtr lpVtbl;
        public IntPtr lpLcl;
        public IntPtr lpLink;
        public uint dwIntRefCnt;
    }
}
