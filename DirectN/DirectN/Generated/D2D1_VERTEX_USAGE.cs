// generated from <Windows SDK Path>\um\d2d1effectauthor.h
namespace DirectN
{
    /// <summary>
    /// Describes how a vertex buffer is to be managed.
    /// </summary>
    public enum D2D1_VERTEX_USAGE
    {
        /// <summary>
        /// The vertex buffer content do not change frequently from frame to frame.
        /// </summary>
        D2D1_VERTEX_USAGE_STATIC = 0,
        
        /// <summary>
        /// The vertex buffer is intended to be updated frequently.
        /// </summary>
        D2D1_VERTEX_USAGE_DYNAMIC = 1,
        
        /// <summary>
        /// The vertex buffer is intended to be updated frequently.
        /// </summary>
        D2D1_VERTEX_USAGE_FORCE_DWORD = -1,
    }
}
