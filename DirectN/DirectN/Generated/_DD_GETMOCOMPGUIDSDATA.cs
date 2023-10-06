// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETMOCOMPGUIDSDATA
    {
        public IntPtr lpDD;
        public uint dwNumGuids;
        public IntPtr lpGuids;
        public HRESULT ddRVal;
    }
}
