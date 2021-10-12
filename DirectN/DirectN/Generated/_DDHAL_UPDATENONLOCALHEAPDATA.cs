// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2688,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_UPDATENONLOCALHEAP = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_UPDATENONLOCALHEAPDATA
    {
        public IntPtr lpDD;
        public uint dwHeap;
        public ulong fpGARTLin;
        public ulong fpGARTDev;
        public IntPtr ulPolicyMaxBytes;
        public HRESULT ddRVal;
        public IntPtr UpdateNonLocalHeap;
    }
}
