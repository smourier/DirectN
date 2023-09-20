// generated from <Windows SDK Path>\um\dmemmgr.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _HEAPALIGNMENT
    {
        public uint dwSize;
        public int ddsCaps;
        public uint dwReserved;
        public _SURFACEALIGNMENT ExecuteBuffer;
        public _SURFACEALIGNMENT Overlay;
        public _SURFACEALIGNMENT Texture;
        public _SURFACEALIGNMENT ZBuffer;
        public _SURFACEALIGNMENT AlphaBuffer;
        public _SURFACEALIGNMENT Offscreen;
        public _SURFACEALIGNMENT FlipTarget;
    }
}
