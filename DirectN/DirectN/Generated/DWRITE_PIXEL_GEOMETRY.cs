// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(877,1)
namespace DirectN
{
    public enum DWRITE_PIXEL_GEOMETRY
    {
        /// <summary>
        /// The red, green, and blue color components of each pixel are assumed to occupy the same point.
        /// </summary>
        DWRITE_PIXEL_GEOMETRY_FLAT = 0,
        
        /// <summary>
        /// Each pixel comprises three vertical stripes, with red on the left, green in the center, and blue on the right. This is the most common pixel geometry for LCD monitors.
        /// </summary>
        DWRITE_PIXEL_GEOMETRY_RGB = 1,
        
        /// <summary>
        /// Each pixel comprises three vertical stripes, with blue on the left, green in the center, and red on the right.
        /// </summary>
        DWRITE_PIXEL_GEOMETRY_BGR = 2,
    }
}
