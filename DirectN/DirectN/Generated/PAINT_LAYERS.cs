// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_LAYERS. Contains one or more child paint elements to be drawn in bottom-up order.  <remarks> This corresponds to a PaintColrLayers record in the OpenType COLR table. Or it may correspond to a BaseGlyph record defined by COLR version 0. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_LAYERS
    {
        /// <summary>
        /// Number of child paint elements in bottom-up order. Use the IDWritePaintReader interface's MoveFirstChild and MoveNextSibling methods to retrieve the child paint elements. Use the MoveParent method to return to the parent element.
        /// </summary>
        public uint childCount;
    }
}
