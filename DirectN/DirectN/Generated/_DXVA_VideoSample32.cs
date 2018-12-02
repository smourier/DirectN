// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1887,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_VideoSample32
    {
        public long rtStart;
        public long rtEnd;
        public uint SampleFormat;
        public uint SampleFlags;
        public uint lpDDSSrcSurface;
        public RECT rcSrc;
        public RECT rcDst;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _DXVA_AYUVsample2[][] Palette;
    }
}
