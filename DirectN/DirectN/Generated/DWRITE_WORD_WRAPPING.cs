// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1797,1)
namespace DirectN
{
    /// <summary>
    /// Word wrapping in multiline paragraph.
    /// </summary>
    public enum DWRITE_WORD_WRAPPING
    {
        /// <summary>
        /// Words are broken across lines to avoid text overflowing the layout box.
        /// </summary>
        DWRITE_WORD_WRAPPING_WRAP = 0,
        
        /// <summary>
        /// Words are kept within the same line even when it overflows the layout box. This option is often used with scrolling to reveal overflow text.
        /// </summary>
        DWRITE_WORD_WRAPPING_NO_WRAP = 1,
        
        /// <summary>
        /// Words are broken across lines to avoid text overflowing the layout box. Emergency wrapping occurs if the word is larger than the maximum width.
        /// </summary>
        DWRITE_WORD_WRAPPING_EMERGENCY_BREAK = 2,
        
        /// <summary>
        /// Only wrap whole words, never breaking words (emergency wrapping) when the layout width is too small for even a single word.
        /// </summary>
        DWRITE_WORD_WRAPPING_WHOLE_WORD = 3,
        
        /// <summary>
        /// Wrap between any valid characters clusters.
        /// </summary>
        DWRITE_WORD_WRAPPING_CHARACTER = 4,
    }
}
