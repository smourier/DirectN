// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(341,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This defines the range of vertices from a vertex buffer to draw.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_VERTEX_RANGE
    {
        public uint startVertex;
        public uint vertexCount;
    }
}
