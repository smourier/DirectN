// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects.h(557,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the 2D Affine Transform effect's top level properties. Effect description: Applies a 2D affine transform to a bitmap.
    /// </summary>
    public enum D2D1_2DAFFINETRANSFORM_PROP
    {
        /// <summary>
        /// Property Name: "InterpolationMode" Property Type: D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE
        /// </summary>
        D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE = 0,
        
        /// <summary>
        /// Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE
        /// </summary>
        D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE = 1,
        
        /// <summary>
        /// Property Name: "TransformMatrix" Property Type: D2D1_MATRIX_3X2_F
        /// </summary>
        D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX = 2,
        
        /// <summary>
        /// Property Name: "Sharpness" Property Type: FLOAT
        /// </summary>
        D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS = 3,
        
        /// <summary>
        /// Property Name: "Sharpness" Property Type: FLOAT
        /// </summary>
        D2D1_2DAFFINETRANSFORM_PROP_FORCE_DWORD = -1,
    }
}
