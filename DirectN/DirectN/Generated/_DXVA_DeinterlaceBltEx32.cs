// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceBltEx32
    {
        public uint Size;
        public _DXVA_AYUVsample2 BackgroundColor;
        public tagRECT rcTarget;
        public long rtTarget;
        public uint NumSourceSurfaces;
        public float Alpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public _DXVA_VideoSample32[] Source;
        public uint DestinationFormat;
        public uint DestinationFlags;
    }
}
