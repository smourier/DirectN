// generated from <Windows SDK Path>\um\d2d1.h
namespace DirectN
{
    /// <summary>
    /// Specifies what the contents are of an opacity mask.
    /// </summary>
    public enum D2D1_OPACITY_MASK_CONTENT
    {
        /// <summary>
        /// The mask contains geometries or bitmaps.
        /// </summary>
        D2D1_OPACITY_MASK_CONTENT_GRAPHICS = 0,
        
        /// <summary>
        /// The mask contains text rendered using one of the natural text modes.
        /// </summary>
        D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL = 1,
        
        /// <summary>
        /// The mask contains text rendered using one of the GDI compatible text modes.
        /// </summary>
        D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE = 2,
        
        /// <summary>
        /// The mask contains text rendered using one of the GDI compatible text modes.
        /// </summary>
        D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD = -1,
    }
}
