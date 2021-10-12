// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effects.h(157,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Directional Blur effect's top level properties. Effect description: Applies a directional blur to a bitmap with the specified blur radius and angle.
    /// </summary>
    public enum D2D1_DIRECTIONALBLUR_PROP
    {
        /// <summary>
        /// Property Name: "StandardDeviation" Property Type: FLOAT
        /// </summary>
        D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION = 0,
        
        /// <summary>
        /// Property Name: "Angle" Property Type: FLOAT
        /// </summary>
        D2D1_DIRECTIONALBLUR_PROP_ANGLE = 1,
        
        /// <summary>
        /// Property Name: "Optimization" Property Type: D2D1_DIRECTIONALBLUR_OPTIMIZATION
        /// </summary>
        D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION = 2,
        
        /// <summary>
        /// Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE
        /// </summary>
        D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE = 3,
        
        /// <summary>
        /// Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE
        /// </summary>
        D2D1_DIRECTIONALBLUR_PROP_FORCE_DWORD = -1,
    }
}
