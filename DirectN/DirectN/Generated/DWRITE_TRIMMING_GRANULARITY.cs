// generated from <Windows SDK Path>\um\dwrite.h
namespace DirectN
{
    /// <summary>
    /// Text granularity used to trim text overflowing the layout box.
    /// </summary>
    public enum DWRITE_TRIMMING_GRANULARITY
    {
        /// <summary>
        /// No trimming occurs. Text flows beyond the layout width.
        /// </summary>
        DWRITE_TRIMMING_GRANULARITY_NONE = 0,
        
        /// <summary>
        /// Trimming occurs at character cluster boundary.
        /// </summary>
        DWRITE_TRIMMING_GRANULARITY_CHARACTER = 1,
        
        /// <summary>
        /// Trimming occurs at word boundary.
        /// </summary>
        DWRITE_TRIMMING_GRANULARITY_WORD = 2,
    }
}
