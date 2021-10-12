// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3236,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_LINE_METRICS structure contains information about a formatted line of text.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_METRICS
    {
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
    }
}
