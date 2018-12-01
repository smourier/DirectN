// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2502,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Shaping output properties per output glyph.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_GLYPH_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        /// <summary>
        /// Justification class, whether to use spacing, kashidas, or another method. This exists for backwards compatibility with Uniscribe's SCRIPT_JUSTIFY enum.
        /// </summary>
        public ushort justification => InteropRuntime.GetUInt16Bits(__bits, 0, 4);
        /// <summary>
        /// Indicates glyph is the first of a cluster.
        /// </summary>
        public ushort isClusterStart => InteropRuntime.GetUInt16Bits(__bits, 4, 1);
        /// <summary>
        /// Glyph is a diacritic.
        /// </summary>
        public ushort isDiacritic => InteropRuntime.GetUInt16Bits(__bits, 5, 1);
        /// <summary>
        /// Glyph has no width, mark, ZWJ, ZWNJ, ZWSP, LRM etc. This flag is not limited to just U+200B.
        /// </summary>
        public ushort isZeroWidthSpace => InteropRuntime.GetUInt16Bits(__bits, 6, 1);
        /// <summary>
        /// Reserved for use by shaping engine.
        /// </summary>
        public ushort reserved => InteropRuntime.GetUInt16Bits(__bits, 7, 9);
    }
}
