// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(944,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Justification information per glyph.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        /// <summary>
        /// Minimum amount of expansion to apply to the side of the glyph. This may vary from 0 to infinity, typically being zero except for kashida.
        /// </summary>
        public float expansionMinimum { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        /// <summary>
        /// Maximum amount of expansion to apply to the side of the glyph. This may vary from 0 to infinity, being zero for fixed-size characters and connected scripts, and non-zero for discrete scripts, and non-zero for cursive scripts at expansion points.
        /// </summary>
        public float expansionMaximum { get => InteropRuntime.GetSingle(__bits, 32, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetSingle(value, __bits, 32, 32); } }
        /// <summary>
        /// Maximum amount of compression to apply to the side of the glyph. This may vary from 0 up to the glyph cluster size.
        /// </summary>
        public float compressionMaximum { get => InteropRuntime.GetSingle(__bits, 64, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetSingle(value, __bits, 64, 32); } }
        /// <summary>
        /// Priority of this expansion point. Larger priorities are applied later, while priority zero does nothing.
        /// </summary>
        public uint expansionPriority { get => InteropRuntime.GetUInt32(__bits, 96, 8); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 96, 8); } }
        /// <summary>
        /// Priority of this compression point. Larger priorities are applied later, while priority zero does nothing.
        /// </summary>
        public uint compressionPriority { get => InteropRuntime.GetUInt32(__bits, 104, 8); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 104, 8); } }
        /// <summary>
        /// Allow this expansion point to use up any remaining slack space even after all expansion priorities have been used up.
        /// </summary>
        public uint allowResidualExpansion { get => InteropRuntime.GetUInt32(__bits, 112, 1); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 112, 1); } }
        /// <summary>
        /// Allow this compression point to use up any remaining space even after all compression priorities have been used up.
        /// </summary>
        public uint allowResidualCompression { get => InteropRuntime.GetUInt32(__bits, 113, 1); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 113, 1); } }
        /// <summary>
        /// Apply expansion/compression to the leading edge of the glyph. This will be false for connected scripts, fixed-size characters, and diacritics. It is generally false within a multi-glyph cluster, unless the script allows expansion of glyphs within a cluster, like Thai.
        /// </summary>
        public uint applyToLeadingEdge { get => InteropRuntime.GetUInt32(__bits, 114, 1); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 114, 1); } }
        /// <summary>
        /// Apply expansion/compression to the trailing edge of the glyph. This will be false for connected scripts, fixed-size characters, and diacritics. It is generally false within a multi-glyph cluster, unless the script allows expansion of glyphs within a cluster, like Thai.
        /// </summary>
        public uint applyToTrailingEdge { get => InteropRuntime.GetUInt32(__bits, 115, 1); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 115, 1); } }
        public uint reserved { get => InteropRuntime.GetUInt32(__bits, 116, 12); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 116, 12); } }
    }
}
