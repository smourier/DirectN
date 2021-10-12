// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(603,1)
namespace DirectN
{
    /// <summary>
    /// How the glyph is oriented to the x-axis. This is an output from the text analyzer, dependent on the desired orientation, bidi level, and character properties.
    /// </summary>
    public enum DWRITE_GLYPH_ORIENTATION_ANGLE
    {
        /// <summary>
        /// Glyph orientation is upright.
        /// </summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_0_DEGREES = 0,
        
        /// <summary>
        /// Glyph orientation is rotated 90 clockwise.
        /// </summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_90_DEGREES = 1,
        
        /// <summary>
        /// Glyph orientation is upside-down.
        /// </summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_180_DEGREES = 2,
        
        /// <summary>
        /// Glyph orientation is rotated 270 clockwise.
        /// </summary>
        DWRITE_GLYPH_ORIENTATION_ANGLE_270_DEGREES = 3,
    }
}
