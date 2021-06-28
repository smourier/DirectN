// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_1.h(722,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Metrics for caret placement in a font.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_CARET_METRICS
    {
        /// <summary>
        /// Vertical rise of the caret. Rise / Run yields the caret angle. Rise = 1 for perfectly upright fonts (non-italic).
        /// </summary>
        public short slopeRise;
        /// <summary>
        /// Horizontal run of th caret. Rise / Run yields the caret angle. Run = 0 for perfectly upright fonts (non-italic).
        /// </summary>
        public short slopeRun;
        /// <summary>
        /// Horizontal offset of the caret along the baseline for good appearance. Offset = 0 for perfectly upright fonts (non-italic).
        /// </summary>
        public short offset;
    }
}
