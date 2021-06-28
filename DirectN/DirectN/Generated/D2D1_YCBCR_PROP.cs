// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects_1.h(34,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the YCbCr effect's top level properties. Effect description: An effect that takes a Y plane as input 0 and a CbCr plane as input 1 and outputs RGBA. The CbCr plane can be chroma subsampled. Useful for JPEG color conversion.
    /// </summary>
    public enum D2D1_YCBCR_PROP
    {
        /// <summary>
        /// Property Name: "ChromaSubsampling" Property Type: D2D1_YCBCR_CHROMA_SUBSAMPLING
        /// </summary>
        D2D1_YCBCR_PROP_CHROMA_SUBSAMPLING = 0,
        
        /// <summary>
        /// Property Name: "TransformMatrix" Property Type: D2D1_MATRIX_3X2_F
        /// </summary>
        D2D1_YCBCR_PROP_TRANSFORM_MATRIX = 1,
        
        /// <summary>
        /// Property Name: "InterpolationMode" Property Type: D2D1_YCBCR_INTERPOLATION_MODE
        /// </summary>
        D2D1_YCBCR_PROP_INTERPOLATION_MODE = 2,
        
        /// <summary>
        /// Property Name: "InterpolationMode" Property Type: D2D1_YCBCR_INTERPOLATION_MODE
        /// </summary>
        D2D1_YCBCR_PROP_FORCE_DWORD = -1,
    }
}
