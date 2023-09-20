// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETPOINTERPOSITION
    {
        public uint VidPnSourceId;
        public int X;
        public int Y;
        public _DXGK_SETPOINTERPOSITIONFLAGS Flags;
    }
}
