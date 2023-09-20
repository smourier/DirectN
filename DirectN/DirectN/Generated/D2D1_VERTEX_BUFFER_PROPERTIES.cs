// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This defines the properties of a vertex buffer which uses the default vertex layout.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_VERTEX_BUFFER_PROPERTIES
    {
        public uint inputCount;
        public D2D1_VERTEX_USAGE usage;
        public IntPtr data;
        public uint byteWidth;
    }
}
