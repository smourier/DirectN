// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(198,9)
namespace DirectN
{
    /// <summary>
    /// Specifies how to render gradient mesh edges.
    /// </summary>
    public enum D2D1_PATCH_EDGE_MODE
    {
        /// <summary>
        /// Render this edge aliased.
        /// </summary>
        D2D1_PATCH_EDGE_MODE_ALIASED = 0,
        
        /// <summary>
        /// Render this edge antialiased.
        /// </summary>
        D2D1_PATCH_EDGE_MODE_ANTIALIASED = 1,
        
        /// <summary>
        /// Render this edge aliased and inflated out slightly.
        /// </summary>
        D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED = 2,
        
        /// <summary>
        /// Render this edge aliased and inflated out slightly.
        /// </summary>
        D2D1_PATCH_EDGE_MODE_FORCE_DWORD = -1,
    }
}
