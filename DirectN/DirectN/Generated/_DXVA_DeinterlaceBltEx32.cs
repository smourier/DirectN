// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1906,9)
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
