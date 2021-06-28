// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1svg.h(30,9)
namespace DirectN
{
    /// <summary>
    /// Specifies the paint type for an SVG fill or stroke.
    /// </summary>
    public enum D2D1_SVG_PAINT_TYPE
    {
        /// <summary>
        /// The fill or stroke is not rendered.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_NONE = 0,
        
        /// <summary>
        /// A solid color is rendered.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_COLOR = 1,
        
        /// <summary>
        /// The current color is rendered.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_CURRENT_COLOR = 2,
        
        /// <summary>
        /// A paint server, defined by another element in the SVG document, is used.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_URI = 3,
        
        /// <summary>
        /// A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_NONE.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_URI_NONE = 4,
        
        /// <summary>
        /// A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_COLOR.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_URI_COLOR = 5,
        
        /// <summary>
        /// A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_CURRENT_COLOR.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR = 6,
        
        /// <summary>
        /// A paint server, defined by another element in the SVG document, is used. If the paint server reference is invalid, fall back to D2D1_SVG_PAINT_TYPE_CURRENT_COLOR.
        /// </summary>
        D2D1_SVG_PAINT_TYPE_FORCE_DWORD = -1,
    }
}
