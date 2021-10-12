// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(2395,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Line breakpoint characteristics of a character.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_BREAKPOINT
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        /// <summary>
        /// Breaking condition before the character.
        /// </summary>
        public byte breakConditionBefore { get => InteropRuntime.GetByte(__bits, 0, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 2); } }
        /// <summary>
        /// Breaking condition after the character.
        /// </summary>
        public byte breakConditionAfter { get => InteropRuntime.GetByte(__bits, 2, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 2); } }
        /// <summary>
        /// The character is some form of whitespace, which may be meaningful for justification.
        /// </summary>
        public byte isWhitespace { get => InteropRuntime.GetByte(__bits, 4, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        /// <summary>
        /// The character is a soft hyphen, often used to indicate hyphenation points inside words.
        /// </summary>
        public byte isSoftHyphen { get => InteropRuntime.GetByte(__bits, 5, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte padding { get => InteropRuntime.GetByte(__bits, 6, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 2); } }
    }
}
