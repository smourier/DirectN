// generated from <Windows SDK Path>\um\dwrite_3.h
namespace DirectN
{
    /// <summary>
    /// Combination of flags specifying attributes of a color glyph or of specific color values in a color glyph.
    /// </summary>
    public enum DWRITE_PAINT_ATTRIBUTES
    {
        DWRITE_PAINT_ATTRIBUTES_NONE = 0,
        
        /// <summary>
        /// Specifies that the color value (or any color value in the glyph) comes from the font's color palette. This means the appearance may depend on the current palette index, which may be important to clients that cache color glyphs.
        /// </summary>
        DWRITE_PAINT_ATTRIBUTES_USES_PALETTE = 1,
        
        /// <summary>
        /// Specifies that the color value (or any color value in the glyph) comes from the client-specified text color. This means the appearance may depend on the text color, which may be important to clients that cache color glyphs.
        /// </summary>
        DWRITE_PAINT_ATTRIBUTES_USES_TEXT_COLOR = 2,
    }
}
