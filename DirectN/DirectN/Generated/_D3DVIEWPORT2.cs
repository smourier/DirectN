// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVIEWPORT2
    {
        public uint dwSize;
        public uint dwX;
        public uint dwY;
        public uint dwWidth;
        public uint dwHeight;
        public float dvClipX;
        public float dvClipY;
        public float dvClipWidth;
        public float dvClipHeight;
        public float dvMinZ;
        public float dvMaxZ;
    }
}
