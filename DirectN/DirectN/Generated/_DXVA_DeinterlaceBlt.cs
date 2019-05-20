// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(584,9)
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
