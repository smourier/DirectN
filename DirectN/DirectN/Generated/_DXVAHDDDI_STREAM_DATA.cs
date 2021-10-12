// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1818,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_DATA
    {
        public bool Enable;
        public uint OutputIndex;
        public uint InputFrameOrField;
        public uint PastFrames;
        public uint FutureFrames;
        public IntPtr pPastSurfaces;
        public _DXVAHDDDI_SURFACE InputSurface;
        public IntPtr pFutureSurfaces;
    }
}
