// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(3423,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_OVERHANG_METRICS structure holds how much any visible pixels (in DIPs) overshoot each side of the layout or inline objects.  <remarks> Positive overhangs indicate that the visible area extends outside the layout box or inline object, while negative values mean there is whitespace inside. The returned values are unaffected by rendering transforms or pixel snapping. Additionally, they may not exactly match final target's pixel bounds after applying grid fitting and hinting. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_OVERHANG_METRICS
    {
        /// <summary>
        /// The distance from the left-most visible DIP to its left alignment edge.
        /// </summary>
        public float left;
        /// <summary>
        /// The distance from the top-most visible DIP to its top alignment edge.
        /// </summary>
        public float top;
        /// <summary>
        /// The distance from the right-most visible DIP to its right alignment edge.
        /// </summary>
        public float right;
        /// <summary>
        /// The distance from the bottom-most visible DIP to its bottom alignment edge.
        /// </summary>
        public float bottom;
    }
}
