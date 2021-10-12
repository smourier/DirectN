// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effects.h(791,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Color Management effect's top level properties. Effect description: Changes colors based on user provided color contexts.
    /// </summary>
    public enum D2D1_COLORMANAGEMENT_PROP
    {
        /// <summary>
        /// Property Name: "SourceColorContext" Property Type: ID2D1ColorContext *
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_SOURCE_COLOR_CONTEXT = 0,
        
        /// <summary>
        /// Property Name: "SourceRenderingIntent" Property Type: D2D1_RENDERING_INTENT
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_SOURCE_RENDERING_INTENT = 1,
        
        /// <summary>
        /// Property Name: "DestinationColorContext" Property Type: ID2D1ColorContext *
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_COLOR_CONTEXT = 2,
        
        /// <summary>
        /// Property Name: "DestinationRenderingIntent" Property Type: D2D1_RENDERING_INTENT
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_DESTINATION_RENDERING_INTENT = 3,
        
        /// <summary>
        /// Property Name: "AlphaMode" Property Type: D2D1_COLORMANAGEMENT_ALPHA_MODE
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_ALPHA_MODE = 4,
        
        /// <summary>
        /// Property Name: "Quality" Property Type: D2D1_COLORMANAGEMENT_QUALITY
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_QUALITY = 5,
        
        /// <summary>
        /// Property Name: "Quality" Property Type: D2D1_COLORMANAGEMENT_QUALITY
        /// </summary>
        D2D1_COLORMANAGEMENT_PROP_FORCE_DWORD = -1,
    }
}
