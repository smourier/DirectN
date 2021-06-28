// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(179,9)
namespace DirectN
{
    /// <summary>
    /// Enum which describes the manner in which we render edges of non-text primitives.
    /// </summary>
    public enum D2D1_ANTIALIAS_MODE
    {
        /// <summary>
        /// The edges of each primitive are antialiased sequentially.
        /// </summary>
        D2D1_ANTIALIAS_MODE_PER_PRIMITIVE = 0,
        
        /// <summary>
        /// Each pixel is rendered if its pixel center is contained by the geometry.
        /// </summary>
        D2D1_ANTIALIAS_MODE_ALIASED = 1,
        
        /// <summary>
        /// Each pixel is rendered if its pixel center is contained by the geometry.
        /// </summary>
        D2D1_ANTIALIAS_MODE_FORCE_DWORD = -1,
    }
}
