// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(1927,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDVIDEOPORT_INT = DirectN._DDRAWI_DDVIDEOPORT_INT;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDVIDEOPORT_INT
    {
        public IntPtr lpVtbl;
        public IntPtr lpLcl;
        public IntPtr lpLink;
        public uint dwIntRefCnt;
        public uint dwFlags;
    }
}
