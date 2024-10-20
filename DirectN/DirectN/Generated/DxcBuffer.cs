// generated from <Windows SDK Path>\um\dxcapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Structure for supplying bytes or text input to Dxc APIs.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DxcBuffer
    {
        /// <summary>
        /// Pointer to the start of the buffer.
        /// </summary>
        public IntPtr Ptr;
        /// <summary>
        /// Size of the buffer in bytes.
        /// </summary>
        public IntPtr Size;
        /// <summary>
        /// Encoding of the buffer.
        /// </summary>
        public uint Encoding;
    }
}
