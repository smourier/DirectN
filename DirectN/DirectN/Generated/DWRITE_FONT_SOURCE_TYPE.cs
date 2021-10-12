// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(3570,1)
namespace DirectN
{
    /// <summary>
    /// The font source type identifies the mechanism by which a font came to be included in a font set.
    /// </summary>
    public enum DWRITE_FONT_SOURCE_TYPE
    {
        /// <summary>
        /// The font source is unknown or is not any of the other defined font source types.
        /// </summary>
        DWRITE_FONT_SOURCE_TYPE_UNKNOWN = 0,
        
        /// <summary>
        /// The font source is a font file, which is installed for all users on the device.
        /// </summary>
        DWRITE_FONT_SOURCE_TYPE_PER_MACHINE = 1,
        
        /// <summary>
        /// The font source is a font file, which is installed for the current user.
        /// </summary>
        DWRITE_FONT_SOURCE_TYPE_PER_USER = 2,
        
        /// <summary>
        /// The font source is an APPX package, which includes one or more font files. The font source name is the full name of the package.
        /// </summary>
        DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE = 3,
        
        /// <summary>
        /// The font source is a font provider for downloadable fonts.
        /// </summary>
        DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER = 4,
    }
}
