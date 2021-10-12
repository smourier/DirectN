// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(313,9)
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
