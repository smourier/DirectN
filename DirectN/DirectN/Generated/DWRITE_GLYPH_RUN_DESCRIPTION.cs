// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_GLYPH_RUN_DESCRIPTION structure contains additional properties related to those in DWRITE_GLYPH_RUN.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_RUN_DESCRIPTION
    {
        /// <summary>
        /// The locale name associated with this run.
        /// </summary>
        public IntPtr localeName;
        /// <summary>
        /// The text associated with the glyphs.
        /// </summary>
        public IntPtr @string;
        /// <summary>
        /// The number of characters (UTF16 code-units). Note that this may be different than the number of glyphs.
        /// </summary>
        public uint stringLength;
        /// <summary>
        /// An array of indices to the glyph indices array, of the first glyphs of all the glyph clusters of the glyphs to render.
        /// </summary>
        public IntPtr clusterMap;
        /// <summary>
        /// Corresponding text position in the original string this glyph run came from.
        /// </summary>
        public uint textPosition;
    }
}
