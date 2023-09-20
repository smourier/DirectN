// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_TEXT_RANGE structure specifies a range of text positions where format is applied.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TEXT_RANGE
    {
        /// <summary>
        /// The start text position of the range.
        /// </summary>
        public uint startPosition;
        /// <summary>
        /// The number of text positions in the range.
        /// </summary>
        public uint length;
    }
}
