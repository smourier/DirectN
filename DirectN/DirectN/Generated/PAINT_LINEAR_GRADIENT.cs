// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_LINEAR_GRADIENT. Specifies a linear gradient used to fill the current shape or clip. This paint element has no child elements.  <remarks> This corresponds to a PaintLinearGradient or PaintVarLinearGradient record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_LINEAR_GRADIENT
    {
        /// <summary>
        /// D2D1_EXTEND_MODE value speciying how colors outside the interval are defined.
        /// </summary>
        public uint extendMode;
        /// <summary>
        /// Number of gradient stops. Use the IDWritePaintReader::GetGradientStops method to get the gradient stops.
        /// </summary>
        public uint gradientStopCount;
        /// <summary>
        /// X coordinate of the start point of the color line.
        /// </summary>
        public float x0;
        /// <summary>
        /// Y coordinate of the start point of the color line.
        /// </summary>
        public float y0;
        /// <summary>
        /// X coordinate of the end point of the color line.
        /// </summary>
        public float x1;
        /// <summary>
        /// Y coordinate of the end point of the color line.
        /// </summary>
        public float y1;
        /// <summary>
        /// X coordinate of the rotation point of the color line.
        /// </summary>
        public float x2;
        /// <summary>
        /// Y coordinate of the rotation point of the color line.
        /// </summary>
        public float y2;
    }
}
