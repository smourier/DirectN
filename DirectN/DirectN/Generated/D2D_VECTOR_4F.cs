// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(210,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A vector of 4 FLOAT values (x, y, z, w).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_VECTOR_4F
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }
}
