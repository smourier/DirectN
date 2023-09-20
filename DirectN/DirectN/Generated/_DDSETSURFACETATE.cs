// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSETSURFACETATE
    {
        public IntPtr hDirectDraw;
        public IntPtr hSurface;
        public uint dwState;
        public uint dwStartField;
    }
}
