// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(451,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This identifies a certain input connection of a certain effect.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        /// <summary>
        /// The effect whose input connection is being specified.
        /// </summary>
        public IntPtr effect;
        /// <summary>
        /// The index of the input connection into the specified effect.
        /// </summary>
        public uint inputIndex;
        /// <summary>
        /// The rectangle which would be available on the specified input connection during render operations.
        /// </summary>
        public D2D_RECT_F inputRectangle;
    }
}
