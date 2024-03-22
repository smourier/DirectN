// generated from <Windows SDK Path>\um\dwrite_3.h
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_COMPOSITE. Combines the two child paint elements using the specified compositing or blending mode. This paint element has two child elements. The first child is the paint source. The second child is the paint destination (or backdrop).  <remarks> This corresponds to a PaintComposite record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_COMPOSITE
    {
        /// <summary>
        /// Specifies the compositing or blending mode.
        /// </summary>
        public DWRITE_COLOR_COMPOSITE_MODE mode;
    }
}
