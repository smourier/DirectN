// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(525,1)
namespace DirectN
{
    /// <summary>
    /// Baseline for text alignment.
    /// </summary>
    public enum DWRITE_BASELINE
    {
        /// <summary>
        /// The Roman baseline for horizontal, Central baseline for vertical.
        /// </summary>
        DWRITE_BASELINE_DEFAULT = 0,
        
        /// <summary>
        /// The baseline used by alphabetic scripts such as Latin, Greek, Cyrillic.
        /// </summary>
        DWRITE_BASELINE_ROMAN = 1,
        
        /// <summary>
        /// Central baseline, generally used for vertical text.
        /// </summary>
        DWRITE_BASELINE_CENTRAL = 2,
        
        /// <summary>
        /// Mathematical baseline which math characters are centered on.
        /// </summary>
        DWRITE_BASELINE_MATH = 3,
        
        /// <summary>
        /// Hanging baseline, used in scripts like Devanagari.
        /// </summary>
        DWRITE_BASELINE_HANGING = 4,
        
        /// <summary>
        /// Ideographic bottom baseline for CJK, left in vertical.
        /// </summary>
        DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM = 5,
        
        /// <summary>
        /// Ideographic top baseline for CJK, right in vertical.
        /// </summary>
        DWRITE_BASELINE_IDEOGRAPHIC_TOP = 6,
        
        /// <summary>
        /// The bottom-most extent in horizontal, left-most in vertical.
        /// </summary>
        DWRITE_BASELINE_MINIMUM = 7,
        
        /// <summary>
        /// The top-most extent in horizontal, right-most in vertical.
        /// </summary>
        DWRITE_BASELINE_MAXIMUM = 8,
    }
}
