// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(3277,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_CLUSTER_METRICS structure contains information about a glyph cluster.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_CLUSTER_METRICS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        /// <summary>
        /// The total advance width of all glyphs in the cluster.
        /// </summary>
        public float width { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        /// <summary>
        /// The number of text positions in the cluster.
        /// </summary>
        public ushort length { get => InteropRuntime.GetUInt16(__bits, 32, 16); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 32, 16); } }
        /// <summary>
        /// Indicate whether line can be broken right after the cluster.
        /// </summary>
        public ushort canWrapLineAfter { get => InteropRuntime.GetUInt16(__bits, 48, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 48, 1); } }
        /// <summary>
        /// Indicate whether the cluster corresponds to whitespace character.
        /// </summary>
        public ushort isWhitespace { get => InteropRuntime.GetUInt16(__bits, 49, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 49, 1); } }
        /// <summary>
        /// Indicate whether the cluster corresponds to a newline character.
        /// </summary>
        public ushort isNewline { get => InteropRuntime.GetUInt16(__bits, 50, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 50, 1); } }
        /// <summary>
        /// Indicate whether the cluster corresponds to soft hyphen character.
        /// </summary>
        public ushort isSoftHyphen { get => InteropRuntime.GetUInt16(__bits, 51, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 51, 1); } }
        /// <summary>
        /// Indicate whether the cluster is read from right to left.
        /// </summary>
        public ushort isRightToLeft { get => InteropRuntime.GetUInt16(__bits, 52, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 52, 1); } }
        public ushort padding { get => InteropRuntime.GetUInt16(__bits, 53, 11); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt16(value, __bits, 53, 11); } }
    }
}
