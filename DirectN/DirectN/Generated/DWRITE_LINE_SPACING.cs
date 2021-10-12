// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1664,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The DWRITE_LINE_SPACING structure specifies the parameters used to specify how to manage space between lines.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_SPACING
    {
        /// <summary>
        /// Method used to determine line spacing.
        /// </summary>
        public DWRITE_LINE_SPACING_METHOD method;
        /// <summary>
        /// Spacing between lines. The interpretation of this parameter depends upon the line spacing method, as follows: - default line spacing: ignored - uniform line spacing: explicit distance in DIPs between lines - proportional line spacing: a scaling factor to be applied to the computed line height; for each line, the height of the line is computed as for default line spacing, and the scaling factor is applied to that value.
        /// </summary>
        public float height;
        /// <summary>
        /// Distance from top of line to baseline. The interpretation of this parameter depends upon the line spacing method, as follows: - default line spacing: ignored - uniform line spacing: explicit distance in DIPs from the top of the line to the baseline - proportional line spacing: a scaling factor applied to the computed baseline; for each line, the baseline distance is computed as for default line spacing, and the scaling factor is applied to that value.
        /// </summary>
        public float baseline;
        /// <summary>
        /// Proportion of the entire leading distributed before the line. The allowed value is between 0 and 1.0. The remaining leading is distributed after the line. It is ignored for the default and uniform line spacing methods. The leading that is available to distribute before or after the line depends on the values of the height and baseline parameters.
        /// </summary>
        public float leadingBefore;
        /// <summary>
        /// Specify whether DWRITE_FONT_METRICS::lineGap value should be part of the line metrics.
        /// </summary>
        public DWRITE_FONT_LINE_GAP_USAGE fontLineGapUsage;
    }
}
