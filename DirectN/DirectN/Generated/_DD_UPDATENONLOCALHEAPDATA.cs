// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1058,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_UPDATENONLOCALHEAPDATA
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
