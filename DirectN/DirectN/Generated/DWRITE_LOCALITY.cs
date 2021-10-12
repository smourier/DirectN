// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(256,1)
namespace DirectN
{
    /// <summary>
    /// Specifies the locality of a resource.
    /// </summary>
    public enum DWRITE_LOCALITY
    {
        /// <summary>
        /// The resource is remote, and information is unknown yet, including the file size and date. Attempting to create a font or file stream will fail until locality becomes at least partial.
        /// </summary>
        DWRITE_LOCALITY_REMOTE = 0,
        
        /// <summary>
        /// The resource is partially local, meaning you can query the size and date of the file stream, and you may be able to create a font face and retrieve the particular glyphs for metrics and drawing, but not all the glyphs will be present.
        /// </summary>
        DWRITE_LOCALITY_PARTIAL = 1,
        
        /// <summary>
        /// The resource is completely local, and all font functions can be called without concern of missing data or errors related to network connectivity.
        /// </summary>
        DWRITE_LOCALITY_LOCAL = 2,
    }
}
