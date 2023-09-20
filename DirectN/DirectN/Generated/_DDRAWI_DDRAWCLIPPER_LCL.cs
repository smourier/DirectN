// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWCLIPPER_GBL = DirectN._DDRAWI_DDRAWCLIPPER_GBL;
using LPDDRAWI_DIRECTDRAW_INT = DirectN._DDRAWI_DIRECTDRAW_INT;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWCLIPPER_LCL
    {
        public uint lpClipMore;
        public IntPtr lpGbl;
        public IntPtr lpDD_lcl;
        public uint dwLocalRefCnt;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnkOuter;
        public IntPtr lpDD_int;
        public IntPtr dwReserved1;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pAddrefedThisOwner;
    }
}
