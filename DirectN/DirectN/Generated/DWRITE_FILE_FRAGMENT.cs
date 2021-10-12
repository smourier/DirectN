// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2087,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// DWRITE_FILE_FRAGMENT represents a range of bytes in a font file.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FILE_FRAGMENT
    {
        /// <summary>
        /// Starting offset of the fragment from the beginning of the file.
        /// </summary>
        public ulong fileOffset;
        /// <summary>
        /// Size of the file fragment, in bytes.
        /// </summary>
        public ulong fragmentSize;
    }
}
