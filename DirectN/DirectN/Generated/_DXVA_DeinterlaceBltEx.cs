// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(599,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceBltEx
    {
        public uint Size;
        public _DXVA_AYUVsample2 BackgroundColor;
        public RECT rcTarget;
        public long rtTarget;
        public uint NumSourceSurfaces;
        public float Alpha;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public _DXVA_VideoSample2[][] Source;
        public uint DestinationFormat;
        public uint DestinationFlags;
    }
}
