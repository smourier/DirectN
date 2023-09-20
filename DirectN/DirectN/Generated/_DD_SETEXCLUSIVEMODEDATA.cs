// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SETEXCLUSIVEMODEDATA
    {
        public IntPtr lpDD;
        public uint dwEnterExcl;
        public uint dwReserved;
        public HRESULT ddRVal;
        public IntPtr SetExclusiveMode;
    }
}
