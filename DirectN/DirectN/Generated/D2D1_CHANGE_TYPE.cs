// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(56,9)
namespace DirectN
{
    /// <summary>
    /// Indicates what has changed since the last time the effect was asked to prepare to render.
    /// </summary>
    public enum D2D1_CHANGE_TYPE
    {
        /// <summary>
        /// Nothing has changed.
        /// </summary>
        D2D1_CHANGE_TYPE_NONE = 0,
        
        /// <summary>
        /// The effect's properties have changed.
        /// </summary>
        D2D1_CHANGE_TYPE_PROPERTIES = 1,
        
        /// <summary>
        /// The internal context has changed and should be inspected.
        /// </summary>
        D2D1_CHANGE_TYPE_CONTEXT = 2,
        
        /// <summary>
        /// A new graph has been set due to a change in the input count.
        /// </summary>
        D2D1_CHANGE_TYPE_GRAPH = 3,
        
        /// <summary>
        /// A new graph has been set due to a change in the input count.
        /// </summary>
        D2D1_CHANGE_TYPE_FORCE_DWORD = -1,
    }
}
