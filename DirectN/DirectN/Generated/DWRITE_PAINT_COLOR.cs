// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a color in a color glyph.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_PAINT_COLOR
    {
        /// <summary>
        /// Color value (not premultiplied). See the colorAttributes member for information about how the color is determined.
        /// </summary>
        public _D3DCOLORVALUE value;
        /// <summary>
        /// If the colorAttributes member is DWRITE_PAINT_ATTRIBUTES_USES_PALETTE, this member is the index of a palette entry in the selected color palette. Otherwise, this member is DWRITE_NO_PALETTE_INDEX (0xFFFF).
        /// </summary>
        public ushort paletteEntryIndex;
        /// <summary>
        /// Specifies an alpha value multiplier in the range 0 to 1 that was used to compute the color value. Color glyph descriptions may include alpha values to be multiplied with the alpha values of palette entries.
        /// </summary>
        public float alphaMultiplier;
        /// <summary>
        /// Specifies how the color value is determined. If this member is DWRITE_PAINT_ATTRIBUTES_USES_PALETTE, the color value is determined by getting the color at paletteEntryIndex in the current color palette. The color's alpha value is then multiplied by alphaMultiplier. If a font has multiple color palettes, a client can set the current color palette using the IDWritePaintReader::SetColorPaletteIndex method. A client that uses a custom palette can use the paletteEntryIndex and alphaMultiplier methods to compute the color. If this member is DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR, the color value is equal to the text foreground color, which can be set using the IDWritePaintReader::SetTextColor method.
        /// </summary>
        public DWRITE_PAINT_ATTRIBUTES colorAttributes;
    }
}
