// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(151,9)
namespace DirectN
{
    /// <summary>
    /// Enum which describes how to sample from a source outside its base tile.
    /// </summary>
    public enum D2D1_EXTEND_MODE
    {
        /// <summary>
        /// Extend the edges of the source out by clamping sample points outside the source to the edges.
        /// </summary>
        D2D1_EXTEND_MODE_CLAMP = 0,
        
        /// <summary>
        /// The base tile is drawn untransformed and the remainder are filled by repeating the base tile.
        /// </summary>
        D2D1_EXTEND_MODE_WRAP = 1,
        
        /// <summary>
        /// The same as wrap, but alternate tiles are flipped The base tile is drawn untransformed.
        /// </summary>
        D2D1_EXTEND_MODE_MIRROR = 2,
        
        /// <summary>
        /// The same as wrap, but alternate tiles are flipped The base tile is drawn untransformed.
        /// </summary>
        D2D1_EXTEND_MODE_FORCE_DWORD = -1,
    }
}
