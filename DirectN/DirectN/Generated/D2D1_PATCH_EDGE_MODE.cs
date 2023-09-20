// generated from <Windows SDK Path>\um\d2d1_3.h
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
