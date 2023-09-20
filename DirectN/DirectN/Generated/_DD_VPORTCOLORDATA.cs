// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_VPORTCOLORDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwFlags;
        public IntPtr lpColorData;
        public HRESULT ddRVal;
        public IntPtr ColorControl;
    }
}
