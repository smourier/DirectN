// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceBlt
    {
        public uint Size;
        public uint Reserved;
        public long rtTarget;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public uint NumSourceSurfaces;
        public float Alpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public _DXVA_VideoSample[] Source;
    }
}
