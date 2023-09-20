// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETSCANLINEDATA
    {
        public IntPtr lpDD;
        public uint dwScanLine;
        public HRESULT ddRVal;
        public IntPtr GetScanLine;
    }
}
