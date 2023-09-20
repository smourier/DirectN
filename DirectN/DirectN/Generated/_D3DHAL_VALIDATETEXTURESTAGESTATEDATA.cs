// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_VALIDATETEXTURESTAGESTATEDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public IntPtr dwReserved;
        public uint dwNumPasses;
        public HRESULT ddrval;
    }
}
