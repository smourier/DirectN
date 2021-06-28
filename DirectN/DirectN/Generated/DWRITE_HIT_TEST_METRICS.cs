// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(3450,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Geometry enclosing of text positions.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_HIT_TEST_METRICS
    {
        /// <summary>
        /// First text position within the geometry.
        /// </summary>
        public uint textPosition;
        /// <summary>
        /// Number of text positions within the geometry.
        /// </summary>
        public uint length;
        /// <summary>
        /// Left position of the top-left coordinate of the geometry.
        /// </summary>
        public float left;
        /// <summary>
        /// Top position of the top-left coordinate of the geometry.
        /// </summary>
        public float top;
        /// <summary>
        /// Geometry's width.
        /// </summary>
        public float width;
        /// <summary>
        /// Geometry's height.
        /// </summary>
        public float height;
        /// <summary>
        /// Bidi level of text positions enclosed within the geometry.
        /// </summary>
        public uint bidiLevel;
        /// <summary>
        /// Geometry encloses text?
        /// </summary>
        public bool isText;
        /// <summary>
        /// Range is trimmed.
        /// </summary>
        public bool isTrimmed;
    }
}
