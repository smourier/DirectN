// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects.h(1931,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Atlas effect's top level properties. Effect description: Changes the available area of the input to the specified rectangle. Provides an optimization for scenarios where a bitmap is used as an atlas.
    /// </summary>
    public enum D2D1_ATLAS_PROP
    {
        /// <summary>
        /// Property Name: "InputRect" Property Type: D2D1_VECTOR_4F
        /// </summary>
        D2D1_ATLAS_PROP_INPUT_RECT = 0,
        
        /// <summary>
        /// Property Name: "InputPaddingRect" Property Type: D2D1_VECTOR_4F
        /// </summary>
        D2D1_ATLAS_PROP_INPUT_PADDING_RECT = 1,
        
        /// <summary>
        /// Property Name: "InputPaddingRect" Property Type: D2D1_VECTOR_4F
        /// </summary>
        D2D1_ATLAS_PROP_FORCE_DWORD = -1,
    }
}
