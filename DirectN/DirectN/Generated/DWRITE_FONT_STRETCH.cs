// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(260,1)
namespace DirectN
{
    /// <summary>
    /// The font stretch enumeration describes relative change from the normal aspect ratio as specified by a font designer for the glyphs in a font. Values less than 1 or greater than 9 are considered to be invalid, and they are rejected by font API functions.
    /// </summary>
    public enum DWRITE_FONT_STRETCH
    {
        /// <summary>
        /// Predefined font stretch : Not known (0).
        /// </summary>
        DWRITE_FONT_STRETCH_UNDEFINED = 0,
        
        /// <summary>
        /// Predefined font stretch : Ultra-condensed (1).
        /// </summary>
        DWRITE_FONT_STRETCH_ULTRA_CONDENSED = 1,
        
        /// <summary>
        /// Predefined font stretch : Extra-condensed (2).
        /// </summary>
        DWRITE_FONT_STRETCH_EXTRA_CONDENSED = 2,
        
        /// <summary>
        /// Predefined font stretch : Condensed (3).
        /// </summary>
        DWRITE_FONT_STRETCH_CONDENSED = 3,
        
        /// <summary>
        /// Predefined font stretch : Semi-condensed (4).
        /// </summary>
        DWRITE_FONT_STRETCH_SEMI_CONDENSED = 4,
        
        /// <summary>
        /// Predefined font stretch : Normal (5).
        /// </summary>
        DWRITE_FONT_STRETCH_NORMAL = 5,
        
        /// <summary>
        /// Predefined font stretch : Medium (5).
        /// </summary>
        DWRITE_FONT_STRETCH_MEDIUM = 5,
        
        /// <summary>
        /// Predefined font stretch : Semi-expanded (6).
        /// </summary>
        DWRITE_FONT_STRETCH_SEMI_EXPANDED = 6,
        
        /// <summary>
        /// Predefined font stretch : Expanded (7).
        /// </summary>
        DWRITE_FONT_STRETCH_EXPANDED = 7,
        
        /// <summary>
        /// Predefined font stretch : Extra-expanded (8).
        /// </summary>
        DWRITE_FONT_STRETCH_EXTRA_EXPANDED = 8,
        
        /// <summary>
        /// Predefined font stretch : Ultra-expanded (9).
        /// </summary>
        DWRITE_FONT_STRETCH_ULTRA_EXPANDED = 9,
    }
}
