// generated from <Windows SDK Path>\um\d2d1effects_2.h
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Cross Fade effect's top level properties. Effect description: This effect combines two images by adding weighted pixels from input images. The formula can be expressed as output = weight * Destination + (1 - weight) * Source
    /// </summary>
    public enum D2D1_CROSSFADE_PROP
    {
        /// <summary>
        /// Property Name: "Weight" Property Type: FLOAT
        /// </summary>
        D2D1_CROSSFADE_PROP_WEIGHT = 0,
        
        /// <summary>
        /// Property Name: "Weight" Property Type: FLOAT
        /// </summary>
        D2D1_CROSSFADE_PROP_FORCE_DWORD = -1,
    }
}
