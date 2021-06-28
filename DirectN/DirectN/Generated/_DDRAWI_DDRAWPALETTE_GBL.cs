// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(1142,9)
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
