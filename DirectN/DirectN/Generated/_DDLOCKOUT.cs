// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddkmapi.h(257,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDLOCKOUT
    {
        public uint ddRVal;
        public uint dwSurfHeight;
        public uint dwSurfWidth;
        public int lSurfPitch;
        public IntPtr lpSurface;
        public uint SurfaceCaps;
        public uint dwFormatFlags;
        public uint dwFormatFourCC;
        public uint dwFormatBitCount;
        public _DDLOCKOUT__union_0 __union_9;
        public _DDLOCKOUT__union_1 __union_10;
        public _DDLOCKOUT__union_2 __union_11;
    }
}
