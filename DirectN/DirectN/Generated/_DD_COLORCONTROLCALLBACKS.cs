// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(585,9)
using System;
using System.Runtime.InteropServices;
using PDD_COLORCB_COLORCONTROL = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_COLORCONTROLCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr ColorControl;
    }
}
