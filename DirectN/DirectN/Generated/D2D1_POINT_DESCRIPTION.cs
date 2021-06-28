// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(479,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes a point along a path.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_POINT_DESCRIPTION
    {
        public D2D_POINT_2F point;
        public D2D_POINT_2F unitTangentVector;
        public uint endSegment;
        public uint endFigure;
        public float lengthToEndSegment;
    }
}
