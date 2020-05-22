// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(967,9)
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
