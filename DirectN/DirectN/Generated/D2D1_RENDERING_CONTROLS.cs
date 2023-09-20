// generated from <Windows SDK Path>\um\d2d1_1.h
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
