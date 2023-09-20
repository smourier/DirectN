// generated from <Windows SDK Path>\um\dwrite_3.h
namespace DirectN
{
    /// <summary>
    /// Apply certain axes automatically in layout during font selection.
    /// </summary>
    public enum DWRITE_AUTOMATIC_FONT_AXES
    {
        /// <summary>
        /// No axes are automatically applied.
        /// </summary>
        DWRITE_AUTOMATIC_FONT_AXES_NONE = 0,
        
        /// <summary>
        /// Automatically pick an appropriate optical value based on the font size (via SetFontSize) when no value is specified via DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE. Callers can still explicitly apply the 'opsz' value over text ranges via SetFontAxisValues, which take priority.
        /// </summary>
        DWRITE_AUTOMATIC_FONT_AXES_OPTICAL_SIZE = 1,
    }
}
