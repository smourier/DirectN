// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Defines a set of typographic features to be applied during shaping. Notice the character range which this feature list spans is specified as a separate parameter to GetGlyphs.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TYPOGRAPHIC_FEATURES
    {
        /// <summary>
        /// Array of font features.
        /// </summary>
        public IntPtr features;
        /// <summary>
        /// The number of features.
        /// </summary>
        public uint featureCount;
    }
}
