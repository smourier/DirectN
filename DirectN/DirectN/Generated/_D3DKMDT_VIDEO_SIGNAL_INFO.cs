// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDEO_SIGNAL_INFO
    {
        public _D3DKMDT_VIDEO_SIGNAL_STANDARD VideoStandard;
        public _D3DKMDT_2DREGION TotalSize;
        public _D3DKMDT_2DREGION ActiveSize;
        public _D3DDDI_RATIONAL VSyncFreq;
        public _D3DDDI_RATIONAL HSyncFreq;
        public IntPtr PixelRate;
        public _D3DKMDT_VIDEO_SIGNAL_INFO__union_0 __union_6;
    }
}
