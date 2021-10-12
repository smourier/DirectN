// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3322,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Overall metrics associated with text after layout. All coordinates are in device independent pixels (DIPs).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TEXT_METRICS
    {
        /// <summary>
        /// Left-most point of formatted text relative to layout box (excluding any glyph overhang).
        /// </summary>
        public float left;
        /// <summary>
        /// Top-most point of formatted text relative to layout box (excluding any glyph overhang).
        /// </summary>
        public float top;
        /// <summary>
        /// The width of the formatted text ignoring trailing whitespace at the end of each line.
        /// </summary>
        public float width;
        /// <summary>
        /// The width of the formatted text taking into account the trailing whitespace at the end of each line.
        /// </summary>
        public float widthIncludingTrailingWhitespace;
        /// <summary>
        /// The height of the formatted text. The height of an empty string is determined by the size of the default font's line height.
        /// </summary>
        public float height;
        /// <summary>
        /// Initial width given to the layout. Depending on whether the text was wrapped or not, it can be either larger or smaller than the text content width.
        /// </summary>
        public float layoutWidth;
        /// <summary>
        /// Initial height given to the layout. Depending on the length of the text, it may be larger or smaller than the text content height.
        /// </summary>
        public float layoutHeight;
        /// <summary>
        /// The maximum reordering count of any line of text, used to calculate the most number of hit-testing boxes needed. If the layout has no bidirectional text or no text at all, the minimum level is 1.
        /// </summary>
        public uint maxBidiReorderingDepth;
        /// <summary>
        /// Total number of lines.
        /// </summary>
        public uint lineCount;
    }
}
