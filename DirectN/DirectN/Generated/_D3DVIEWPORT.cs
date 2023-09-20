// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVIEWPORT
    {
        public uint dwSize;
        public uint dwX;
        public uint dwY;
        public uint dwWidth;
        public uint dwHeight;
        public float dvScaleX;
        public float dvScaleY;
        public float dvMaxX;
        public float dvMaxY;
        public float dvMinZ;
        public float dvMaxZ;
    }
}
