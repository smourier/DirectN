// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effects.h(1339,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Linear Transfer effect's top level properties. Effect description: Remaps the color intensities of the input bitmap based on a user specified linear transfer function for each RGBA channel.
    /// </summary>
    public enum D2D1_LINEARTRANSFER_PROP
    {
        /// <summary>
        /// Property Name: "RedYIntercept" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT = 0,
        
        /// <summary>
        /// Property Name: "RedSlope" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_RED_SLOPE = 1,
        
        /// <summary>
        /// Property Name: "RedDisable" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_RED_DISABLE = 2,
        
        /// <summary>
        /// Property Name: "GreenYIntercept" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT = 3,
        
        /// <summary>
        /// Property Name: "GreenSlope" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE = 4,
        
        /// <summary>
        /// Property Name: "GreenDisable" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE = 5,
        
        /// <summary>
        /// Property Name: "BlueYIntercept" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT = 6,
        
        /// <summary>
        /// Property Name: "BlueSlope" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE = 7,
        
        /// <summary>
        /// Property Name: "BlueDisable" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE = 8,
        
        /// <summary>
        /// Property Name: "AlphaYIntercept" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT = 9,
        
        /// <summary>
        /// Property Name: "AlphaSlope" Property Type: FLOAT
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE = 10,
        
        /// <summary>
        /// Property Name: "AlphaDisable" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE = 11,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT = 12,
        
        /// <summary>
        /// Property Name: "ClampOutput" Property Type: BOOL
        /// </summary>
        D2D1_LINEARTRANSFER_PROP_FORCE_DWORD = -1,
    }
}
