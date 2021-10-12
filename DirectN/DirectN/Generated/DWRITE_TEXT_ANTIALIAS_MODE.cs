// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(1877,1)
namespace DirectN
{
    /// <summary>
    /// Represents the type of antialiasing to use for text when the rendering mode calls for antialiasing.
    /// </summary>
    public enum DWRITE_TEXT_ANTIALIAS_MODE
    {
        /// <summary>
        /// ClearType antialiasing computes coverage independently for the red, green, and blue color elements of each pixel. This allows for more detail than conventional antialiasing. However, because there is no one alpha value for each pixel, ClearType is not suitable rendering text onto a transparent intermediate bitmap.
        /// </summary>
        DWRITE_TEXT_ANTIALIAS_MODE_CLEARTYPE = 0,
        
        /// <summary>
        /// Grayscale antialiasing computes one coverage value for each pixel. Because the alpha value of each pixel is well-defined, text can be rendered onto a transparent bitmap, which can then be composited with other content. Note that grayscale rendering with IDWriteBitmapRenderTarget1 uses premultiplied alpha.
        /// </summary>
        DWRITE_TEXT_ANTIALIAS_MODE_GRAYSCALE = 1,
    }
}
