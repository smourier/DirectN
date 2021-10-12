// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(809,9)
namespace DirectN
{
    /// <summary>
    /// Describes the minimum DirectX support required for hardware rendering by a render target.
    /// </summary>
    public enum D2D1_FEATURE_LEVEL
    {
        /// <summary>
        /// The caller does not require a particular underlying D3D device level.
        /// </summary>
        D2D1_FEATURE_LEVEL_DEFAULT = 0,
        
        /// <summary>
        /// The D3D device level is DX9 compatible.
        /// </summary>
        D2D1_FEATURE_LEVEL_9 = 37120,
        
        /// <summary>
        /// The D3D device level is DX10 compatible.
        /// </summary>
        D2D1_FEATURE_LEVEL_10 = 40960,
        
        /// <summary>
        /// The D3D device level is DX10 compatible.
        /// </summary>
        D2D1_FEATURE_LEVEL_FORCE_DWORD = -1,
    }
}
