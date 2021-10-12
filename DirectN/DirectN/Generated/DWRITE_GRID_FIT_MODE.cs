// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(44,1)
namespace DirectN
{
    /// <summary>
    /// Whether to enable grid-fitting of glyph outlines (a.k.a. hinting).
    /// </summary>
    public enum DWRITE_GRID_FIT_MODE
    {
        /// <summary>
        /// Choose grid fitting base on the font's gasp table information.
        /// </summary>
        DWRITE_GRID_FIT_MODE_DEFAULT = 0,
        
        /// <summary>
        /// Always disable grid fitting, using the ideal glyph outlines.
        /// </summary>
        DWRITE_GRID_FIT_MODE_DISABLED = 1,
        
        /// <summary>
        /// Enable grid fitting, adjusting glyph outlines for device pixel display.
        /// </summary>
        DWRITE_GRID_FIT_MODE_ENABLED = 2,
    }
}
