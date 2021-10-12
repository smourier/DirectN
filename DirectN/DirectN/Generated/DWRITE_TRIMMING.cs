// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(2019,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_TRIMMING structure specifies the trimming option for text overflowing the layout box.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TRIMMING
    {
        /// <summary>
        /// Text granularity of which trimming applies.
        /// </summary>
        public DWRITE_TRIMMING_GRANULARITY granularity;
        /// <summary>
        /// Character code used as the delimiter signaling the beginning of the portion of text to be preserved, most useful for path ellipsis, where the delimiter would be a slash. Leave this zero if there is no delimiter.
        /// </summary>
        public uint delimiter;
        /// <summary>
        /// How many occurrences of the delimiter to step back. Leave this zero if there is no delimiter.
        /// </summary>
        public uint delimiterCount;
    }
}
