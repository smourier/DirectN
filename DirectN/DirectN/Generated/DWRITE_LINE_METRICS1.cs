// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Information about a formatted line of text.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_METRICS1
    {
        // struct DWRITE_LINE_METRICS
        /// <summary>
        /// The number of total text positions in the line. This includes any trailing whitespace and newline characters.
        /// </summary>
        public uint length;
        /// <summary>
        /// The number of whitespace positions at the end of the line. Newline sequences are considered whitespace.
        /// </summary>
        public uint trailingWhitespaceLength;
        /// <summary>
        /// The number of characters in the newline sequence at the end of the line. If the count is zero, then the line was either wrapped or it is the end of the text.
        /// </summary>
        public uint newlineLength;
        /// <summary>
        /// Height of the line as measured from top to bottom.
        /// </summary>
        public float height;
        /// <summary>
        /// Distance from the top of the line to its baseline.
        /// </summary>
        public float baseline;
        /// <summary>
        /// The line is trimmed.
        /// </summary>
        public bool isTrimmed;
        
        // DWRITE_LINE_METRICS1
        /// <summary>
        /// White space before the content of the line. This is included in the line height and baseline distances. If the line is formatted horizontally either with a uniform line spacing or with proportional line spacing, this value represents the extra space above the content.
        /// </summary>
        public float leadingBefore;
        /// <summary>
        /// White space after the content of the line. This is included in the height of the line. If the line is formatted horizontally either with a uniform line spacing or with proportional line spacing, this value represents the extra space below the content.
        /// </summary>
        public float leadingAfter;
    }
}
