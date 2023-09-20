// generated from <Windows SDK Path>\um\d2d1_1.h
namespace DirectN
{
    /// <summary>
    /// Defines how the world transform, dots per inch (dpi), and stroke width affect the shape of the pen used to stroke a primitive.
    /// </summary>
    public enum D2D1_STROKE_TRANSFORM_TYPE
    {
        /// <summary>
        /// The stroke respects the world transform, the DPI, and the stroke width.
        /// </summary>
        D2D1_STROKE_TRANSFORM_TYPE_NORMAL = 0,
        
        /// <summary>
        /// The stroke does not respect the world transform, but it does respect the DPI and the stroke width.
        /// </summary>
        D2D1_STROKE_TRANSFORM_TYPE_FIXED = 1,
        
        /// <summary>
        /// The stroke is forced to one pixel wide.
        /// </summary>
        D2D1_STROKE_TRANSFORM_TYPE_HAIRLINE = 2,
        
        /// <summary>
        /// The stroke is forced to one pixel wide.
        /// </summary>
        D2D1_STROKE_TRANSFORM_TYPE_FORCE_DWORD = -1,
    }
}
