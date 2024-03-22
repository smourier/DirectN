// generated from <Windows SDK Path>\um\dwrite_3.h
namespace DirectN
{
    /// <summary>
    /// Defines known feature level for use with the IDWritePaintReader interface and related APIs. A feature level represents a level of functionality. For example, it determines what DWRITE_PAINT_TYPE values might be returned.  <remarks> See the DWRITE_PAINT_TYPE enumeration for which paint types are required for each feature level. </remarks>
    /// </summary>
    public enum DWRITE_PAINT_FEATURE_LEVEL
    {
        /// <summary>
        /// No paint API support.
        /// </summary>
        DWRITE_PAINT_FEATURE_LEVEL_NONE = 0,
        
        /// <summary>
        /// Specifies a level of functionality corresponding to OpenType COLR version 0.
        /// </summary>
        DWRITE_PAINT_FEATURE_LEVEL_COLR_V0 = 1,
        
        /// <summary>
        /// Specifies a level of functionality corresponding to OpenType COLR version 1.
        /// </summary>
        DWRITE_PAINT_FEATURE_LEVEL_COLR_V1 = 2,
    }
}
