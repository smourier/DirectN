// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1853,1)
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
