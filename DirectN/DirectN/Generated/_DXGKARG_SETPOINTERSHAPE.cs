// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1657,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETPOINTERSHAPE
    {
        public _DXGK_POINTERFLAGS Flags;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public uint VidPnSourceId;
        public IntPtr pPixels;
        public uint XHot;
        public uint YHot;
    }
}
