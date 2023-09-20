// generated from <Windows SDK Path>\um\strmif.h
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
