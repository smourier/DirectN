// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2439,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Value for a font axis, used when querying and creating font instances.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_AXIS_VALUE
    {
        /// <summary>
        /// Four character identifier of the font axis (weight, width, slant, italic...).
        /// </summary>
        public DWRITE_FONT_AXIS_TAG axisTag;
        /// <summary>
        /// Value for the given axis, with the meaning and range depending on the axis semantics. Certain well known axes have standard ranges and defaults, such as weight (1..1000, default=400), width (>0, default=100), slant (-90..90, default=-20), and italic (0 or 1).
        /// </summary>
        public float value;
    }
}
