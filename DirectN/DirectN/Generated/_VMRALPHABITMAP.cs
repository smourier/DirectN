// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(21112,9)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRALPHABITMAP
    {
        public uint dwFlags;
        public IntPtr hdc;
        public IntPtr pDDS;
        public tagRECT rSrc;
        public _NORMALIZEDRECT rDest;
        public float fAlpha;
        public uint clrSrcKey;
    }
}
