// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3034,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_GLYPH_RUN structure contains the information needed by renderers to draw glyph runs. All coordinates are in device independent pixels (DIPs).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_RUN
    {
        /// <summary>
        /// The physical font face to draw with.
        /// </summary>
        public IntPtr fontFace;
        /// <summary>
        /// Logical size of the font in DIPs, not points (equals 1/96 inch).
        /// </summary>
        public float fontEmSize;
        /// <summary>
        /// The number of glyphs.
        /// </summary>
        public uint glyphCount;
        /// <summary>
        /// The indices to render.
        /// </summary>
        public IntPtr glyphIndices;
        /// <summary>
        /// Glyph advance widths.
        /// </summary>
        public IntPtr glyphAdvances;
        /// <summary>
        /// Glyph offsets.
        /// </summary>
        public IntPtr glyphOffsets;
        /// <summary>
        /// If true, specifies that glyphs are rotated 90 degrees to the left and vertical metrics are used. Vertical writing is achieved by specifying isSideways = true and rotating the entire run 90 degrees to the right via a rotate transform.
        /// </summary>
        public bool isSideways;
        /// <summary>
        /// The implicit resolved bidi level of the run. Odd levels indicate right-to-left languages like Hebrew and Arabic, while even levels indicate left-to-right languages like English and Japanese (when written horizontally). For right-to-left languages, the text origin is on the right, and text should be drawn to the left.
        /// </summary>
        public uint bidiLevel;
    }
}
