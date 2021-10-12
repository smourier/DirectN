// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(124,9)
namespace DirectN
{
    /// <summary>
    /// Qualifies how alpha is to be treated in a bitmap or render target containing alpha.
    /// </summary>
    public enum D2D1_ALPHA_MODE
    {
        /// <summary>
        /// Alpha mode should be determined implicitly. Some target surfaces do not supply or imply this information in which case alpha must be specified.
        /// </summary>
        D2D1_ALPHA_MODE_UNKNOWN = 0,
        
        /// <summary>
        /// Treat the alpha as premultipled.
        /// </summary>
        D2D1_ALPHA_MODE_PREMULTIPLIED = 1,
        
        /// <summary>
        /// Opacity is in the 'A' component only.
        /// </summary>
        D2D1_ALPHA_MODE_STRAIGHT = 2,
        
        /// <summary>
        /// Ignore any alpha channel information.
        /// </summary>
        D2D1_ALPHA_MODE_IGNORE = 3,
        
        /// <summary>
        /// Ignore any alpha channel information.
        /// </summary>
        D2D1_ALPHA_MODE_FORCE_DWORD = -1,
    }
}
