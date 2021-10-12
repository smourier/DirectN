// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(819,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Range of Unicode codepoints.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_UNICODE_RANGE
    {
        /// <summary>
        /// The first codepoint in the Unicode range.
        /// </summary>
        public uint first;
        /// <summary>
        /// The last codepoint in the Unicode range.
        /// </summary>
        public uint last;
    }
}
