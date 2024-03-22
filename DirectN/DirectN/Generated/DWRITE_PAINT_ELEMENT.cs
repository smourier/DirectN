// generated from <Windows SDK Path>\um\dwrite_3.h
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Specifies properties of a paint element, which is one node in a visual tree associated with a color glyph. This is passed as an output parameter to various IDWritePaintReader methods.  <remarks> For a detailed description of how paint elements should be rendered, see the OpenType COLR table specification. Comments below reference the COLR paint record formats associated with each paint type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_PAINT_ELEMENT
    {
        /// <summary>
        /// Specifies the paint type, and thus which member of the union is valid.
        /// </summary>
        public DWRITE_PAINT_TYPE paintType;
        /// <summary>
        /// Specifies type-specific properties of the paint element.
        /// </summary>
        public PAINT_UNION PAINT_UNION;
        public PAINT_UNION paint;
    }
}
