// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_1.h(579,1)
namespace DirectN
{
    /// <summary>
    /// The desired kind of glyph orientation for the text. The client specifies this to the analyzer as the desired orientation, but note this is the client preference, and the constraints of the script will determine the final presentation.
    /// </summary>
    public enum DWRITE_VERTICAL_GLYPH_ORIENTATION
    {
        /// <summary>
        /// In vertical layout, naturally horizontal scripts (Latin, Thai, Arabic, Devanagari) rotate 90 degrees clockwise, while ideographic scripts (Chinese, Japanese, Korean) remain upright, 0 degrees.
        /// </summary>
        DWRITE_VERTICAL_GLYPH_ORIENTATION_DEFAULT = 0,
        
        /// <summary>
        /// Ideographic scripts and scripts that permit stacking (Latin, Hebrew) are stacked in vertical reading layout. Connected scripts (Arabic, Syriac, 'Phags-pa, Ogham), which would otherwise look broken if glyphs were kept at 0 degrees, remain connected and rotate.
        /// </summary>
        DWRITE_VERTICAL_GLYPH_ORIENTATION_STACKED = 1,
    }
}
