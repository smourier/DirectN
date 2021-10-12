// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(67,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Overall metrics associated with text after layout. All coordinates are in device independent pixels (DIPs).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TEXT_METRICS1
    {
        // struct DWRITE_TEXT_METRICS
        public float left;
        public float top;
        public float width;
        public float widthIncludingTrailingWhitespace;
        public float height;
        public float layoutWidth;
        public float layoutHeight;
        public uint maxBidiReorderingDepth;
        public uint lineCount;
        
        // DWRITE_TEXT_METRICS1
        /// <summary>
        /// The height of the formatted text taking into account the trailing whitespace at the end of each line, which will matter for vertical reading directions.
        /// </summary>
        public float heightIncludingTrailingWhitespace;
    }
}
