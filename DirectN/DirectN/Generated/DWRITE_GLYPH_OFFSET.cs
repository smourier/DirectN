// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(600,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Optional adjustment to a glyph's position. A glyph offset changes the position of a glyph without affecting the pen position. Offsets are in logical, pre-transform units.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_OFFSET
    {
        /// <summary>
        /// Offset in the advance direction of the run. A positive advance offset moves the glyph to the right (in pre-transform coordinates) if the run is left-to-right or to the left if the run is right-to-left.
        /// </summary>
        public float advanceOffset;
        /// <summary>
        /// Offset in the ascent direction, i.e., the direction ascenders point. A positive ascender offset moves the glyph up (in pre-transform coordinates).
        /// </summary>
        public float ascenderOffset;
    }
}
