// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDMOTIONCOMP_LCL
    {
        public IntPtr lpDD;
        public Guid guid;
        public uint dwUncompWidth;
        public uint dwUncompHeight;
        public _DDPIXELFORMAT ddUncompPixelFormat;
        public uint dwInternalFlags;
        public uint dwRefCnt;
        public uint dwProcessId;
        public IntPtr hMoComp;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public IntPtr lpDriverReserved1;
        public IntPtr lpDriverReserved2;
        public IntPtr lpDriverReserved3;
    }
}
