// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATS
    {
        public uint dwSize;
        public uint dwTrianglesDrawn;
        public uint dwLinesDrawn;
        public uint dwPointsDrawn;
        public uint dwSpansDrawn;
        public uint dwVerticesProcessed;
    }
}
