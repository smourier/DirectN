// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(199,9)
namespace DirectN
{
    /// <summary>
    /// Describes the antialiasing mode used for drawing text.
    /// </summary>
    public enum D2D1_TEXT_ANTIALIAS_MODE
    {
        /// <summary>
        /// Render text using the current system setting.
        /// </summary>
        D2D1_TEXT_ANTIALIAS_MODE_DEFAULT = 0,
        
        /// <summary>
        /// Render text using ClearType.
        /// </summary>
        D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE = 1,
        
        /// <summary>
        /// Render text using gray-scale.
        /// </summary>
        D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE = 2,
        
        /// <summary>
        /// Render text aliased.
        /// </summary>
        D2D1_TEXT_ANTIALIAS_MODE_ALIASED = 3,
        
        /// <summary>
        /// Render text aliased.
        /// </summary>
        D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD = -1,
    }
}
