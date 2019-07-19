// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1effects.h(201,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Shadow effect's top level properties. Effect description: Applies a shadow to a bitmap based on its alpha channel.
    /// </summary>
    public enum D2D1_SHADOW_PROP
    {
        /// <summary>
        /// Property Name: "BlurStandardDeviation" Property Type: FLOAT
        /// </summary>
        D2D1_SHADOW_PROP_BLUR_STANDARD_DEVIATION = 0,
        
        /// <summary>
        /// Property Name: "Color" Property Type: D2D1_VECTOR_4F
        /// </summary>
        D2D1_SHADOW_PROP_COLOR = 1,
        
        /// <summary>
        /// Property Name: "Optimization" Property Type: D2D1_SHADOW_OPTIMIZATION
        /// </summary>
        D2D1_SHADOW_PROP_OPTIMIZATION = 2,
        
        /// <summary>
        /// Property Name: "Optimization" Property Type: D2D1_SHADOW_OPTIMIZATION
        /// </summary>
        D2D1_SHADOW_PROP_FORCE_DWORD = -1,
    }
}
