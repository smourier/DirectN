// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dtypes.h(1887,9)
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
