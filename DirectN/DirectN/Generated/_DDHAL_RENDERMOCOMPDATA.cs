// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2937,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_RENDER = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_RENDERMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public uint dwNumBuffers;
        public IntPtr lpBufferInfo;
        public uint dwFunction;
        public IntPtr lpInputData;
        public uint dwInputDataSize;
        public IntPtr lpOutputData;
        public uint dwOutputDataSize;
        public HRESULT ddRVal;
        public IntPtr RenderMoComp;
    }
}
