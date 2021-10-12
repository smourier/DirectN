// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(35,9)
namespace DirectN
{
    /// <summary>
    /// The measuring method used for text layout.
    /// </summary>
    public enum DWRITE_MEASURING_MODE
    {
        /// <summary>
        /// Text is measured using glyph ideal metrics whose values are independent to the current display resolution.
        /// </summary>
        DWRITE_MEASURING_MODE_NATURAL = 0,
        
        /// <summary>
        /// Text is measured using glyph display compatible metrics whose values tuned for the current display resolution.
        /// </summary>
        DWRITE_MEASURING_MODE_GDI_CLASSIC = 1,
        DWRITE_MEASURING_MODE_GDI_NATURAL = 2,
    }
}
