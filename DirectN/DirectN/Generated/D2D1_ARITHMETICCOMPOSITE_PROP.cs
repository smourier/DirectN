// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effects.h(1791,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Arithmetic Composite effect's top level properties. Effect description: Composites two bitmaps based on the following algorithm: Output = Coefficients_1 * Source * Destination + Coefficients_2 * Source+ Coefficients_3 * Destination + Coefficients_4.
    /// </summary>
    public enum D2D1_ARITHMETICCOMPOSITE_PROP
    {
        /// <summary>
        /// Property Name: "Coefficients" Property Type: D2D1_VECTOR_4F
        /// </summary>
        D2D1_ARITHMETICCOMPOSITE_PROP_COEFFICIENTS = 0,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_ARITHMETICCOMPOSITE_PROP_CLAMP_OUTPUT = 1,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_ARITHMETICCOMPOSITE_PROP_FORCE_DWORD = -1,
    }
}
