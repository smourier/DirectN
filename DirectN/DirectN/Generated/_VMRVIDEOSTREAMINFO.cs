// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRVIDEOSTREAMINFO
    {
        public IntPtr pddsVideoSurface;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwStrmID;
        public float fAlpha;
        public _DDCOLORKEY ddClrKey;
        public _NORMALIZEDRECT rNormal;
    }
}
