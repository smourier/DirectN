// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_GBL_MORE
    {
        public uint dwSize;
        public _DDRAWI_DDRAWSURFACE_GBL_MORE__union_0 __union_1;
        public IntPtr pPageTable;
        public uint cPages;
        public IntPtr dwSavedDCContext;
        public ulong fpAliasedVidMem;
        public IntPtr dwDriverReserved;
        public IntPtr dwHELReserved;
        public uint cPageUnlocks;
        public IntPtr hKernelSurface;
        public uint dwKernelRefCnt;
        public IntPtr lpColorInfo;
        public ulong fpNTAlias;
        public uint dwContentsStamp;
        public IntPtr lpvUnswappedDriverReserved;
        public IntPtr lpDDRAWReserved2;
        public uint dwDDRAWReserved1;
        public uint dwDDRAWReserved2;
        public ulong fpAliasOfVidMem;
    }
}
