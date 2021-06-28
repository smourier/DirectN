// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects.h(363,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Bitmap Source effect's top level properties. Effect description: Provides an image source.
    /// </summary>
    public enum D2D1_BITMAPSOURCE_PROP
    {
        /// <summary>
        /// Property Name: "WicBitmapSource" Property Type: IUnknown *
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE = 0,
        
        /// <summary>
        /// Property Name: "Scale" Property Type: D2D1_VECTOR_2F
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_SCALE = 1,
        
        /// <summary>
        /// Property Name: "InterpolationMode" Property Type: D2D1_BITMAPSOURCE_INTERPOLATION_MODE
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE = 2,
        
        /// <summary>
        /// Property Name: "EnableDPICorrection" Property Type: BOOL
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION = 3,
        
        /// <summary>
        /// Property Name: "AlphaMode" Property Type: D2D1_BITMAPSOURCE_ALPHA_MODE
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_ALPHA_MODE = 4,
        
        /// <summary>
        /// Property Name: "Orientation" Property Type: D2D1_BITMAPSOURCE_ORIENTATION
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_ORIENTATION = 5,
        
        /// <summary>
        /// Property Name: "Orientation" Property Type: D2D1_BITMAPSOURCE_ORIENTATION
        /// </summary>
        D2D1_BITMAPSOURCE_PROP_FORCE_DWORD = -1,
    }
}
