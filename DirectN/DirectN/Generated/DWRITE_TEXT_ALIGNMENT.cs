// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1749,1)
namespace DirectN
{
    /// <summary>
    /// Alignment of paragraph text along the reading direction axis relative to the leading and trailing edge of the layout box.
    /// </summary>
    public enum DWRITE_TEXT_ALIGNMENT
    {
        /// <summary>
        /// The leading edge of the paragraph text is aligned to the layout box's leading edge.
        /// </summary>
        DWRITE_TEXT_ALIGNMENT_LEADING = 0,
        
        /// <summary>
        /// The trailing edge of the paragraph text is aligned to the layout box's trailing edge.
        /// </summary>
        DWRITE_TEXT_ALIGNMENT_TRAILING = 1,
        
        /// <summary>
        /// The center of the paragraph text is aligned to the center of the layout box.
        /// </summary>
        DWRITE_TEXT_ALIGNMENT_CENTER = 2,
        
        /// <summary>
        /// Align text to the leading side, and also justify text to fill the lines.
        /// </summary>
        DWRITE_TEXT_ALIGNMENT_JUSTIFIED = 3,
    }
}
