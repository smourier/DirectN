// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_VideoSample
    {
        public long rtStart;
        public long rtEnd;
        public _DXVA_SampleFormat SampleFormat;
        public IntPtr lpDDSSrcSurface;
    }
}
