// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1623,1)
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
        public uint length;
        public uint trailingWhitespaceLength;
        public uint newlineLength;
        public float height;
        public float baseline;
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
