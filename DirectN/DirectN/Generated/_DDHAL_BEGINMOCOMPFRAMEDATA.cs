// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2898,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_BEGINFRAME = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_BEGINMOCOMPFRAMEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpDestSurface;
        public uint dwInputDataSize;
        public IntPtr lpInputData;
        public uint dwOutputDataSize;
        public IntPtr lpOutputData;
        public HRESULT ddRVal;
        public IntPtr BeginMoCompFrame;
    }
}
