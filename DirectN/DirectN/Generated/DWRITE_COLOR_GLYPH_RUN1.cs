// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color glyph run. The IDWriteFactory4::TranslateColorGlyphRun method returns an ordered collection of color glyph runs of varying types depending on what the font supports.   For runs without any specific color, such as PNG data, the runColor field will be zero.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_COLOR_GLYPH_RUN1
    {
        // struct DWRITE_COLOR_GLYPH_RUN
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
        
        // DWRITE_COLOR_GLYPH_RUN1
        /// <summary>
        /// Type of glyph image format for this color run. Exactly one type will be set since TranslateColorGlyphRun has already broken down the run into separate parts.
        /// </summary>
        public DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat;
        /// <summary>
        /// Measuring mode to use for this glyph run.
        /// </summary>
        public DWRITE_MEASURING_MODE measuringMode;
    }
}
