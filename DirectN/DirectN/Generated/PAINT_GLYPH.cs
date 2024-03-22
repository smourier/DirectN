// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_GLYPH. Specifies a glyph shape to be filled or, equivalently, a clip region. This paint element has one child element.  <remarks> The child paint element defines how the glyph shape is filled. The child element can be a single paint element, such as a linear gradient. Or the child element can be the root of a visual tree to be rendered with the glyph shape as a clip region. This corresponds to a PaintGlyph record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_GLYPH
    {
        /// <summary>
        /// Glyph index of the glyph that defines the shape to be filled.
        /// </summary>
        public uint glyphIndex;
    }
}
