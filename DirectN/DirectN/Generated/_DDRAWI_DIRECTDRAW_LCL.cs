// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDGAMMACALIBRATORPROC = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DIRECTDRAW_LCL
    {
        public uint lpDDMore;
        public IntPtr lpGbl;
        public uint dwUnused0;
        public uint dwLocalFlags;
        public uint dwLocalRefCnt;
        public uint dwProcessId;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnkOuter;
        public uint dwObsolete1;
        public IntPtr hWnd;
        public IntPtr hDC;
        public uint dwErrorMode;
        public IntPtr lpPrimary;
        public IntPtr lpCB;
        public uint dwPreferredMode;
        public IntPtr hD3DInstance;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pD3DIUnknown;
        public IntPtr lpDDCB;
        public IntPtr hDDVxd;
        public uint dwAppHackFlags;
        public IntPtr hFocusWnd;
        public uint dwHotTracking;
        public uint dwIMEState;
        public IntPtr hWndPopup;
        public IntPtr hDD;
        public IntPtr hGammaCalibrator;
        public IntPtr lpGammaCalibrator;
    }
}
