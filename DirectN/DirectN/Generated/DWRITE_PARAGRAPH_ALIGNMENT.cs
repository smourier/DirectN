// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1776,1)
namespace DirectN
{
    /// <summary>
    /// Alignment of paragraph text along the flow direction axis relative to the flow's beginning and ending edge of the layout box.
    /// </summary>
    public enum DWRITE_PARAGRAPH_ALIGNMENT
    {
        /// <summary>
        /// The first line of paragraph is aligned to the flow's beginning edge of the layout box.
        /// </summary>
        DWRITE_PARAGRAPH_ALIGNMENT_NEAR = 0,
        
        /// <summary>
        /// The last line of paragraph is aligned to the flow's ending edge of the layout box.
        /// </summary>
        DWRITE_PARAGRAPH_ALIGNMENT_FAR = 1,
        
        /// <summary>
        /// The center of the paragraph is aligned to the center of the flow of the layout box.
        /// </summary>
        DWRITE_PARAGRAPH_ALIGNMENT_CENTER = 2,
    }
}
