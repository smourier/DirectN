// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
