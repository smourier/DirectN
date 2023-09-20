// generated from <Windows SDK Path>\um\dwrite_1.h
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
