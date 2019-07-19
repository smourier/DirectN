// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1effects.h(605,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the DPI Compensation effect's top level properties. Effect description: Scales according to the input DPI and the current context DPI
    /// </summary>
    public enum D2D1_DPICOMPENSATION_PROP
    {
        /// <summary>
        /// Property Name: "InterpolationMode" Property Type: D2D1_DPICOMPENSATION_INTERPOLATION_MODE
        /// </summary>
        D2D1_DPICOMPENSATION_PROP_INTERPOLATION_MODE = 0,
        
        /// <summary>
        /// Property Name: "BorderMode" Property Type: D2D1_BORDER_MODE
        /// </summary>
        D2D1_DPICOMPENSATION_PROP_BORDER_MODE = 1,
        
        /// <summary>
        /// Property Name: "InputDpi" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_DPICOMPENSATION_PROP_INPUT_DPI = 2,
        
        /// <summary>
        /// Property Name: "InputDpi" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_DPICOMPENSATION_PROP_FORCE_DWORD = -1,
    }
}
