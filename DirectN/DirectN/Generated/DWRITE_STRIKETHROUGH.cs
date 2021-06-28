// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(3185,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_STRIKETHROUGH structure contains information about the size and placement of strikethroughs. All coordinates are in device independent pixels (DIPs).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_STRIKETHROUGH
    {
        /// <summary>
        /// Width of the strikethrough, measured parallel to the baseline.
        /// </summary>
        public float width;
        /// <summary>
        /// Thickness of the strikethrough, measured perpendicular to the baseline.
        /// </summary>
        public float thickness;
        /// <summary>
        /// Offset of the strikethrough from the baseline. A positive offset represents a position below the baseline and a negative offset is above.
        /// </summary>
        public float offset;
        /// <summary>
        /// Reading direction of the text associated with the strikethrough. This value is used to interpret whether the width value runs horizontally or vertically.
        /// </summary>
        public DWRITE_READING_DIRECTION readingDirection;
        /// <summary>
        /// Flow direction of the text associated with the strikethrough. This value is used to interpret whether the thickness value advances top to bottom, left to right, or right to left.
        /// </summary>
        public DWRITE_FLOW_DIRECTION flowDirection;
        /// <summary>
        /// Locale of the range. Can be pertinent where the locale affects the style.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char localeName;
        /// <summary>
        /// The measuring mode can be useful to the renderer to determine how underlines are rendered, e.g. rounding the thickness to a whole pixel in GDI-compatible modes.
        /// </summary>
        public DWRITE_MEASURING_MODE measuringMode;
    }
}
