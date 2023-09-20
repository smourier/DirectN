// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWPALETTE_LCL
    {
        public uint lpPalMore;
        public IntPtr lpGbl;
        public IntPtr dwUnused0;
        public uint dwLocalRefCnt;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnkOuter;
        public IntPtr lpDD_lcl;
        public IntPtr dwReserved1;
        public IntPtr dwDDRAWReserved1;
        public IntPtr dwDDRAWReserved2;
        public IntPtr dwDDRAWReserved3;
    }
}
