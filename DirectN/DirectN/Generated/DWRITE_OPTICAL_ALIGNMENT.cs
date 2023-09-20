// generated from <Windows SDK Path>\um\dwrite_2.h
namespace DirectN
{
    /// <summary>
    /// How to align glyphs to the margin.
    /// </summary>
    public enum DWRITE_OPTICAL_ALIGNMENT
    {
        /// <summary>
        /// Align to the default metrics of the glyph.
        /// </summary>
        DWRITE_OPTICAL_ALIGNMENT_NONE = 0,
        
        /// <summary>
        /// Align glyphs to the margins. Without this, some small whitespace may be present between the text and the margin from the glyph's side bearing values. Note that glyphs may still overhang outside the margin, such as flourishes or italic slants.
        /// </summary>
        DWRITE_OPTICAL_ALIGNMENT_NO_SIDE_BEARINGS = 1,
    }
}
