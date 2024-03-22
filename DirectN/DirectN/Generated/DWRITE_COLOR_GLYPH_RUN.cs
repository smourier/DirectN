// generated from <Windows SDK Path>\um\dwrite_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color glyph run. The IDWriteFactory2::TranslateColorGlyphRun method returns an ordered collection of color glyph runs, which can be layered on top of each other to produce a color representation of the given base glyph run.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_COLOR_GLYPH_RUN
    {
        /// <summary>
        /// Glyph run to render.
        /// </summary>
        public DWRITE_GLYPH_RUN glyphRun;
        /// <summary>
        /// Optional glyph run description.
        /// </summary>
        public IntPtr glyphRunDescription;
        /// <summary>
        /// Location at which to draw this glyph run.
        /// </summary>
        public float baselineOriginX;
        public float baselineOriginY;
        /// <summary>
        /// Color to use for this layer, if any. If the paletteIndex member is DWRITE_NO_PALETTE_INDEX (0xFFFF) then no color is specifed by the font, this member is set to { 0, 0, 0, 0 }, and the client should use the current foreground brush. Otherwise, this member is set to a color from the font's color palette, i.e., the same color that would be returned by IDWriteFontFace2::GetPaletteEntries for the current palette index.
        /// </summary>
        public _D3DCOLORVALUE runColor;
        /// <summary>
        /// Zero-based index of this layer's color entry in the current color palette, or DWRITE_NO_PALETTE_INDEX (0xFFFF) if this layer is to be rendered using the current foreground brush.
        /// </summary>
        public ushort paletteIndex;
    }
}
