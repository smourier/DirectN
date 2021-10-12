// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effects.h(869,9)
namespace DirectN
{
    /// <summary>
    /// The enumeration of the Histogram effect's top level properties. Effect description: Computes the histogram of an image.
    /// </summary>
    public enum D2D1_HISTOGRAM_PROP
    {
        /// <summary>
        /// Property Name: "NumBins" Property Type: UINT32
        /// </summary>
        D2D1_HISTOGRAM_PROP_NUM_BINS = 0,
        
        /// <summary>
        /// Property Name: "ChannelSelect" Property Type: D2D1_CHANNEL_SELECTOR
        /// </summary>
        D2D1_HISTOGRAM_PROP_CHANNEL_SELECT = 1,
        
        /// <summary>
        /// Property Name: "HistogramOutput" Property Type: (blob)
        /// </summary>
        D2D1_HISTOGRAM_PROP_HISTOGRAM_OUTPUT = 2,
        
        /// <summary>
        /// Property Name: "HistogramOutput" Property Type: (blob)
        /// </summary>
        D2D1_HISTOGRAM_PROP_FORCE_DWORD = -1,
    }
}
