// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1effectauthor.h(313,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_VERTEX_BUFFER_PROPERTIES
    {
        public uint inputCount;
        public D2D1_VERTEX_USAGE usage;
        public IntPtr data;
        public uint byteWidth;
    }
}
