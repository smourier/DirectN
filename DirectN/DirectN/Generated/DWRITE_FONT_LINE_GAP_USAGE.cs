// generated from <Windows SDK Path>\um\dwrite_3.h
namespace DirectN
{
    /// <summary>
    /// Specify whether DWRITE_FONT_METRICS::lineGap value should be part of the line metrics.
    /// </summary>
    public enum DWRITE_FONT_LINE_GAP_USAGE
    {
        /// <summary>
        /// The usage of the font line gap depends on the method used for text layout.
        /// </summary>
        DWRITE_FONT_LINE_GAP_USAGE_DEFAULT = 0,
        
        /// <summary>
        /// The font line gap is excluded from line spacing
        /// </summary>
        DWRITE_FONT_LINE_GAP_USAGE_DISABLED = 1,
        
        /// <summary>
        /// The font line gap is included in line spacing
        /// </summary>
        DWRITE_FONT_LINE_GAP_USAGE_ENABLED = 2,
    }
}
