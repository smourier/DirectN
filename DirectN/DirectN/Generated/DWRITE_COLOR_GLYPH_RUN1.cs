// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1802,1)
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
        public DWRITE_GLYPH_RUN glyphRun;
        public IntPtr glyphRunDescription;
        public float baselineOriginX;
        public float baselineOriginY;
        public _D3DCOLORVALUE runColor;
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
