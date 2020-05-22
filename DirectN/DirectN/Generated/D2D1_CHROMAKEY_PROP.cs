// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects_2.h(144,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Chroma Key effect's top level properties. Effect description: Converts a specified color to transparent.
    /// </summary>
    public enum D2D1_CHROMAKEY_PROP
    {
        /// <summary>
        /// Property Name: "Color" Property Type: D2D1_VECTOR_3F
        /// </summary>
        D2D1_CHROMAKEY_PROP_COLOR = 0,
        
        /// <summary>
        /// Property Name: "Tolerance" Property Type: FLOAT
        /// </summary>
        D2D1_CHROMAKEY_PROP_TOLERANCE = 1,
        
        /// <summary>
        /// Property Name: "InvertAlpha" Property Type: BOOL
        /// </summary>
        D2D1_CHROMAKEY_PROP_INVERT_ALPHA = 2,
        
        /// <summary>
        /// Property Name: "Feather" Property Type: BOOL
        /// </summary>
        D2D1_CHROMAKEY_PROP_FEATHER = 3,
        
        /// <summary>
        /// Property Name: "Feather" Property Type: BOOL
        /// </summary>
        D2D1_CHROMAKEY_PROP_FORCE_DWORD = -1,
    }
}
