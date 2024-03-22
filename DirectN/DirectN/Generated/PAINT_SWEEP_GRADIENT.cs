// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_SWEEP_GRADIENT. Specifies a sweep gradient used to fill the current shape or clip. This paint element has no child elements.  <remarks> This corresponds to a PaintSweepGradient or PaintVarSweepGradient record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_SWEEP_GRADIENT
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
        /// Center X coordinate.
        /// </summary>
        public float centerX;
        /// <summary>
        /// Center Y coordinate.
        /// </summary>
        public float centerY;
        /// <summary>
        /// Start of the angular range of the gradient, measured in counter-clockwise degrees from the direction of the positive x axis.
        /// </summary>
        public float startAngle;
        /// <summary>
        /// End of the angular range of the gradient, measured in counter-clockwise degrees from the direction of the positive x axis.
        /// </summary>
        public float endAngle;
    }
}
