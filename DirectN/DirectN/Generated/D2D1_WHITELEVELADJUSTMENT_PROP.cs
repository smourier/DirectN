// generated from <Windows SDK Path>\um\d2d1effects_2.h
namespace DirectN
{
    /// <summary>
    /// The enumeration of the White Level Adjustment effect's top level properties. Effect description: This effect adjusts the white level of the source image by multiplying the source image color by the ratio of the input and output white levels. Input and output white levels are specified in nits.
    /// </summary>
    public enum D2D1_WHITELEVELADJUSTMENT_PROP
    {
        /// <summary>
        /// Property Name: "InputWhiteLevel" Property Type: FLOAT
        /// </summary>
        D2D1_WHITELEVELADJUSTMENT_PROP_INPUT_WHITE_LEVEL = 0,
        
        /// <summary>
        /// Property Name: "OutputWhiteLevel" Property Type: FLOAT
        /// </summary>
        D2D1_WHITELEVELADJUSTMENT_PROP_OUTPUT_WHITE_LEVEL = 1,
        
        /// <summary>
        /// Property Name: "OutputWhiteLevel" Property Type: FLOAT
        /// </summary>
        D2D1_WHITELEVELADJUSTMENT_PROP_FORCE_DWORD = -1,
    }
}
