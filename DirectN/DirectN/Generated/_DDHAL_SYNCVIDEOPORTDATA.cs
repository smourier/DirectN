// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2790,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SYNCVIDEOPORTDATA
    {
        public uint dwSize;
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwOriginOffset;
        public uint dwHeight;
        public uint dwVBIHeight;
        public IntPtr dwDriverReserved1;
        public IntPtr dwDriverReserved2;
        public IntPtr dwDriverReserved3;
        public HRESULT ddRVal;
    }
}
