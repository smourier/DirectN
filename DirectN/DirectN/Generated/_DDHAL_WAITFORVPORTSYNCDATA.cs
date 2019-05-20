// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2577,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_WAITFORSYNC = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_WAITFORVPORTSYNCDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwFlags;
        public uint dwLine;
        public uint dwTimeOut;
        public HRESULT ddRVal;
        public IntPtr WaitForVideoPortSync;
    }
}
