// generated from <Windows SDK Path>\um\d2d1effects.h
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Color Matrix effect's top level properties. Effect description: Applies a user specified color matrix to each channel of the input bitmap.
    /// </summary>
    public enum D2D1_COLORMATRIX_PROP
    {
        /// <summary>
        /// Property Name: "ColorMatrix" Property Type: D2D1_MATRIX_5X4_F
        /// </summary>
        D2D1_COLORMATRIX_PROP_COLOR_MATRIX = 0,
        
        /// <summary>
        /// Property Name: "AlphaMode" Property Type: D2D1_COLORMATRIX_ALPHA_MODE
        /// </summary>
        D2D1_COLORMATRIX_PROP_ALPHA_MODE = 1,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_COLORMATRIX_PROP_CLAMP_OUTPUT = 2,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_COLORMATRIX_PROP_FORCE_DWORD = -1,
    }
}
