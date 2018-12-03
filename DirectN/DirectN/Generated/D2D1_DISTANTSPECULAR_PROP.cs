// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effects.h(1048,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Distant-Specular effect's top level properties. Effect description: Creates a specular lighting effect with a distant light source.
    /// </summary>
    public enum D2D1_DISTANTSPECULAR_PROP
    {
        /// <summary>
        /// Property Name: "Azimuth" Property Type: FLOAT
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_AZIMUTH = 0,
        
        /// <summary>
        /// Property Name: "Elevation" Property Type: FLOAT
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_ELEVATION = 1,
        
        /// <summary>
        /// Property Name: "SpecularExponent" Property Type: FLOAT
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_SPECULAR_EXPONENT = 2,
        
        /// <summary>
        /// Property Name: "SpecularConstant" Property Type: FLOAT
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_SPECULAR_CONSTANT = 3,
        
        /// <summary>
        /// Property Name: "SurfaceScale" Property Type: FLOAT
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_SURFACE_SCALE = 4,
        
        /// <summary>
        /// Property Name: "Color" Property Type: D2D1_VECTOR_3F
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_COLOR = 5,
        
        /// <summary>
        /// Property Name: "KernelUnitLength" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_KERNEL_UNIT_LENGTH = 6,
        
        /// <summary>
        /// Property Name: "ScaleMode" Property Type: D2D1_DISTANTSPECULAR_SCALE_MODE
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_SCALE_MODE = 7,
        
        /// <summary>
        /// Property Name: "ScaleMode" Property Type: D2D1_DISTANTSPECULAR_SCALE_MODE
        /// </summary>
        D2D1_DISTANTSPECULAR_PROP_FORCE_DWORD = -1,
    }
}
