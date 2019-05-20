// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1278,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_VIDEOSAMPLE
    {
        public long Start;
        public long End;
        public _DXVADDI_EXTENDEDFORMAT SampleFormat;
        public _DXVADDI_VIDEOSAMPLEFLAGS SampleFlags;
        public IntPtr SrcResource;
        public uint SrcSubResourceIndex;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public _DXVADDI_AYUVSAMPLE8[] Pal;
        public _DXVADDI_FIXED32 PlanarAlpha;
    }
}
