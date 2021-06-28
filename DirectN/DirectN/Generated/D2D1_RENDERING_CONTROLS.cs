// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(432,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This controls advanced settings of the Direct2D imaging pipeline.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_RENDERING_CONTROLS
    {
        /// <summary>
        /// The default buffer precision, used if the precision isn't otherwise specified.
        /// </summary>
        public D2D1_BUFFER_PRECISION bufferPrecision;
        /// <summary>
        /// The size of allocated tiles used to render imaging effects.
        /// </summary>
        public D2D_SIZE_U tileSize;
    }
}
