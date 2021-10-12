// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effects_2.h(386,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Edge Detection effect's top level properties. Effect description: Detects edges of an image.
    /// </summary>
    public enum D2D1_EDGEDETECTION_PROP
    {
        /// <summary>
        /// Property Name: "Strength" Property Type: FLOAT
        /// </summary>
        D2D1_EDGEDETECTION_PROP_STRENGTH = 0,
        
        /// <summary>
        /// Property Name: "BlurRadius" Property Type: FLOAT
        /// </summary>
        D2D1_EDGEDETECTION_PROP_BLUR_RADIUS = 1,
        
        /// <summary>
        /// Property Name: "Mode" Property Type: D2D1_EDGEDETECTION_MODE
        /// </summary>
        D2D1_EDGEDETECTION_PROP_MODE = 2,
        
        /// <summary>
        /// Property Name: "OverlayEdges" Property Type: BOOL
        /// </summary>
        D2D1_EDGEDETECTION_PROP_OVERLAY_EDGES = 3,
        
        /// <summary>
        /// Property Name: "AlphaMode" Property Type: D2D1_ALPHA_MODE
        /// </summary>
        D2D1_EDGEDETECTION_PROP_ALPHA_MODE = 4,
        
        /// <summary>
        /// Property Name: "AlphaMode" Property Type: D2D1_ALPHA_MODE
        /// </summary>
        D2D1_EDGEDETECTION_PROP_FORCE_DWORD = -1,
    }
}
