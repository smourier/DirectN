// generated from <Windows SDK Path>\um\d2d1.h
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
