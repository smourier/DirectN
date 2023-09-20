// generated from <Windows SDK Path>\um\ddrawint.h
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
