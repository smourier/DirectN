// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(2327,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_WAITFORVERTICALBLANK = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_WAITFORVERTICALBLANKDATA
    {
        public IntPtr lpDD;
        public uint dwFlags;
        public uint bIsInVB;
        public IntPtr hEvent;
        public HRESULT ddRVal;
        public IntPtr WaitForVerticalBlank;
    }
}
