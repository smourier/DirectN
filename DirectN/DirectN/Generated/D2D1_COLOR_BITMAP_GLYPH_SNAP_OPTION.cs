// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(373,9)
namespace DirectN
{
    /// <summary>
    /// Specifies the pixel snapping policy when rendering color bitmap glyphs.
    /// </summary>
    public enum D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION
    {
        /// <summary>
        /// Color bitmap glyph positions are snapped to the nearest pixel if the bitmap resolution matches that of the device context.
        /// </summary>
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT = 0,
        
        /// <summary>
        /// Color bitmap glyph positions are not snapped.
        /// </summary>
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE = 1,
        
        /// <summary>
        /// Color bitmap glyph positions are not snapped.
        /// </summary>
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD = -1,
    }
}
