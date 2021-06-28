// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(967,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_MATRIX structure specifies the graphics transform to be applied to rendered glyphs.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_MATRIX
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
