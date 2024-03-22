// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Valid for paint elements of type DWRITE_PAINT_TYPE_RADIAL_GRADIENT. Specifies a radial gradient used to fill the current shape or clip. This paint element has no child elements.  <remarks> This corresponds to a PaintRadialGradient or PaintVarRadialGradient record in the OpenType COLR table. </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAINT_RADIAL_GRADIENT
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
        /// Center X coordinate of the start circle.
        /// </summary>
        public float x0;
        /// <summary>
        /// Center Y coordinate of the start circle.
        /// </summary>
        public float y0;
        /// <summary>
        /// Radius of the start circle.
        /// </summary>
        public float radius0;
        /// <summary>
        /// Center X coordinate of the end circle.
        /// </summary>
        public float x1;
        /// <summary>
        /// Center Y coordinate of the end circle.
        /// </summary>
        public float y1;
        /// <summary>
        /// Radius of the end circle.
        /// </summary>
        public float radius1;
    }
}
