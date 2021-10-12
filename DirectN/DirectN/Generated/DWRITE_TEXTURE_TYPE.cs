// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(4619,1)
namespace DirectN
{
    /// <summary>
    /// The DWRITE_TEXTURE_TYPE enumeration identifies a type of alpha texture. An alpha texture is a bitmap of alpha values, each representing the darkness (i.e., opacity) of a pixel or subpixel.
    /// </summary>
    public enum DWRITE_TEXTURE_TYPE
    {
        /// <summary>
        /// Specifies an alpha texture for aliased text rendering (i.e., bi-level, where each pixel is either fully opaque or fully transparent), with one byte per pixel.
        /// </summary>
        DWRITE_TEXTURE_ALIASED_1x1 = 0,
        
        /// <summary>
        /// Specifies an alpha texture for ClearType text rendering, with three bytes per pixel in the horizontal dimension and one byte per pixel in the vertical dimension.
        /// </summary>
        DWRITE_TEXTURE_CLEARTYPE_3x1 = 1,
    }
}
