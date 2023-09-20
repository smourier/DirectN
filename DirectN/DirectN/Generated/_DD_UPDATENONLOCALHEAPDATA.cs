// generated from <Windows SDK Path>\um\ddrawint.h
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
