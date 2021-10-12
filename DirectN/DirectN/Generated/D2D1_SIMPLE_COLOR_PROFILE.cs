// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(419,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Simple description of a color space.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_SIMPLE_COLOR_PROFILE
    {
        /// <summary>
        /// The XY coordinates of the red primary in CIEXYZ space.
        /// </summary>
        public D2D_POINT_2F redPrimary;
        /// <summary>
        /// The XY coordinates of the green primary in CIEXYZ space.
        /// </summary>
        public D2D_POINT_2F greenPrimary;
        /// <summary>
        /// The XY coordinates of the blue primary in CIEXYZ space.
        /// </summary>
        public D2D_POINT_2F bluePrimary;
        /// <summary>
        /// The X/Z tristimulus values for the whitepoint, normalized for relative luminance.
        /// </summary>
        public D2D_POINT_2F whitePointXZ;
        /// <summary>
        /// The gamma encoding to use for this color space.
        /// </summary>
        public D2D1_GAMMA1 gamma;
    }
}
