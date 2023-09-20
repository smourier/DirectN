// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _ACCESSRECTLIST
    {
        public IntPtr lpLink;
        public tagRECT rDest;
        public IntPtr lpOwner;
        public IntPtr lpSurfaceData;
        public uint dwFlags;
        public IntPtr lpHeapAliasInfo;
    }
}
