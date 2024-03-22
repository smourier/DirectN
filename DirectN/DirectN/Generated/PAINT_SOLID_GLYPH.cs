// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_SOLID_GLYPH. Specifies a glyph with a solid color fill. This paint element has no child elements.  <remarks> This corresponds to a combination of two paint records in the OpenType COLR table: a PaintGlyph record, which references either a PaintSolid or PaintVarSolid record. Or it may correspond to a Layer record defined by COLR version 0. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_SOLID_GLYPH
    {
        /// <summary>
        /// Glyph index defining the shape to be filled.
        /// </summary>
        public uint glyphIndex;
        /// <summary>
        /// Glyph color used to fill the glyph shape.
        /// </summary>
        public DWRITE_PAINT_COLOR color;
    }
}
