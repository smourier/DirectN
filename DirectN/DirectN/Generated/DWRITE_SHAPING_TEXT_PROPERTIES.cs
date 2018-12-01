// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(2473,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Shaping output properties per input character.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SHAPING_TEXT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        /// <summary>
        /// This character can be shaped independently from the others (usually set for the space character).
        /// </summary>
        public ushort isShapedAlone => InteropRuntime.GetUInt16Bits(__bits, 0, 1);
        /// <summary>
        /// Reserved for use by shaping engine.
        /// </summary>
        public ushort reserved1 => InteropRuntime.GetUInt16Bits(__bits, 1, 1);
        /// <summary>
        /// Glyph shaping can be cut after this point without affecting shaping before or after it. Otherwise, splitting a call to GetGlyphs would cause a reflow of glyph advances and shapes.
        /// </summary>
        public ushort canBreakShapingAfter => InteropRuntime.GetUInt16Bits(__bits, 2, 1);
        /// <summary>
        /// Reserved for use by shaping engine.
        /// </summary>
        public ushort reserved => InteropRuntime.GetUInt16Bits(__bits, 3, 13);
    }
}
