// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWPALETTE_GBL
    {
        public uint dwRefCnt;
        public uint dwFlags;
        public IntPtr lpDD_lcl;
        public uint dwProcessId;
        public IntPtr lpColorTable;
        public _DDRAWI_DDRAWPALETTE_GBL__union_0 __union_5;
        public uint dwDriverReserved;
        public uint dwContentsStamp;
        public uint dwSaveStamp;
        public uint dwHandle;
    }
}
