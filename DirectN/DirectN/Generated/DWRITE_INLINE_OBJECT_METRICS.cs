// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(3386,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Properties describing the geometric measurement of an application-defined inline object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_INLINE_OBJECT_METRICS
    {
        /// <summary>
        /// Width of the inline object.
        /// </summary>
        public float width;
        /// <summary>
        /// Height of the inline object as measured from top to bottom.
        /// </summary>
        public float height;
        /// <summary>
        /// Distance from the top of the object to the baseline where it is lined up with the adjacent text. If the baseline is at the bottom, baseline simply equals height.
        /// </summary>
        public float baseline;
        /// <summary>
        /// Flag indicating whether the object is to be placed upright or alongside the text baseline for vertical text.
        /// </summary>
        public bool supportsSideways;
    }
}
