// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_COLOR_GLYPH. Specifies another color glyph, used as a reusable component. This paint element has one child element, which is the root paint element of the specified color glyph.  <remarks> This corresponds to a PaintColorGlyph record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_COLOR_GLYPH
    {
        /// <summary>
        /// Glyph index of the referenced color glyph.
        /// </summary>
        public uint glyphIndex;
        /// <summary>
        /// Clip box of the referenced color glyph, in ems. This is an empty rectangle of the color glyph does not specify a clip box. If it is not an empty rect, the client is required to clip the child content to this box.
        /// </summary>
        public D2D_RECT_F clipBox;
    }
}
