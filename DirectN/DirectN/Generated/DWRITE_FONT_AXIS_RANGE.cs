// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2458,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Minimum and maximum range of a font axis.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_AXIS_RANGE
    {
        /// <summary>
        /// Four character identifier of the font axis (weight, width, slant, italic...).
        /// </summary>
        public DWRITE_FONT_AXIS_TAG axisTag;
        /// <summary>
        /// Minimum value supported by this axis.
        /// </summary>
        public float minValue;
        /// <summary>
        /// Maximum value supported by this axis. The maximum can equal the minimum.
        /// </summary>
        public float maxValue;
    }
}
