// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effects_2.h(602,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the HDR Tone Map effect's top level properties. Effect description: Adjusts the maximum luminance of the source image to fit within the maximum output luminance supported. Input and output luminance values are specified in nits. Note that the color space of the image is assumed to be scRGB.
    /// </summary>
    public enum D2D1_HDRTONEMAP_PROP
    {
        /// <summary>
        /// Property Name: "InputMaxLuminance" Property Type: FLOAT
        /// </summary>
        D2D1_HDRTONEMAP_PROP_INPUT_MAX_LUMINANCE = 0,
        
        /// <summary>
        /// Property Name: "OutputMaxLuminance" Property Type: FLOAT
        /// </summary>
        D2D1_HDRTONEMAP_PROP_OUTPUT_MAX_LUMINANCE = 1,
        
        /// <summary>
        /// Property Name: "DisplayMode" Property Type: D2D1_HDRTONEMAP_DISPLAY_MODE
        /// </summary>
        D2D1_HDRTONEMAP_PROP_DISPLAY_MODE = 2,
        
        /// <summary>
        /// Property Name: "DisplayMode" Property Type: D2D1_HDRTONEMAP_DISPLAY_MODE
        /// </summary>
        D2D1_HDRTONEMAP_PROP_FORCE_DWORD = -1,
    }
}
