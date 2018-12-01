// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dcommon.h(279,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_3X2_F__union_0__struct_0
    {
        /// <summary>
        /// Horizontal scaling / cosine of rotation
        /// </summary>
        public float m11;
        /// <summary>
        /// Vertical shear / sine of rotation
        /// </summary>
        public float m12;
        /// <summary>
        /// Horizontal shear / negative sine of rotation
        /// </summary>
        public float m21;
        /// <summary>
        /// Vertical scaling / cosine of rotation
        /// </summary>
        public float m22;
        /// <summary>
        /// Horizontal shift (always orthogonal regardless of rotation)
        /// </summary>
        public float dx;
        /// <summary>
        /// Vertical shift (always orthogonal regardless of rotation)
        /// </summary>
        public float dy;
    }
}
