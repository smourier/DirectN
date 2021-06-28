// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(547,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_GLYPH_METRICS structure specifies the metrics of an individual glyph. The units depend on how the metrics are obtained.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_METRICS
    {
        /// <summary>
        /// Specifies the X offset from the glyph origin to the left edge of the black box. The glyph origin is the current horizontal writing position. A negative value means the black box extends to the left of the origin (often true for lowercase italic 'f').
        /// </summary>
        public int leftSideBearing;
        /// <summary>
        /// Specifies the X offset from the origin of the current glyph to the origin of the next glyph when writing horizontally.
        /// </summary>
        public uint advanceWidth;
        /// <summary>
        /// Specifies the X offset from the right edge of the black box to the origin of the next glyph when writing horizontally. The value is negative when the right edge of the black box overhangs the layout box.
        /// </summary>
        public int rightSideBearing;
        /// <summary>
        /// Specifies the vertical offset from the vertical origin to the top of the black box. Thus, a positive value adds whitespace whereas a negative value means the glyph overhangs the top of the layout box.
        /// </summary>
        public int topSideBearing;
        /// <summary>
        /// Specifies the Y offset from the vertical origin of the current glyph to the vertical origin of the next glyph when writing vertically. (Note that the term "origin" by itself denotes the horizontal origin. The vertical origin is different. Its Y coordinate is specified by verticalOriginY value, and its X coordinate is half the advanceWidth to the right of the horizontal origin).
        /// </summary>
        public uint advanceHeight;
        /// <summary>
        /// Specifies the vertical distance from the black box's bottom edge to the advance height. Positive when the bottom edge of the black box is within the layout box. Negative when the bottom edge of black box overhangs the layout box.
        /// </summary>
        public int bottomSideBearing;
        /// <summary>
        /// Specifies the Y coordinate of a glyph's vertical origin, in the font's design coordinate system. The y coordinate of a glyph's vertical origin is the sum of the glyph's top side bearing and the top (i.e. yMax) of the glyph's bounding box.
        /// </summary>
        public int verticalOriginY;
    }
}
