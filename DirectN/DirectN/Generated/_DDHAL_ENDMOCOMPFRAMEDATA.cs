// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2914,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_ENDFRAME = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_ENDMOCOMPFRAMEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpInputData;
        public uint dwInputDataSize;
        public HRESULT ddRVal;
        public IntPtr EndMoCompFrame;
    }
}
