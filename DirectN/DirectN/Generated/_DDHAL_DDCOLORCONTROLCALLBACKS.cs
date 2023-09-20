// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALCOLORCB_COLORCONTROL = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDCOLORCONTROLCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr ColorControl;
    }
}
