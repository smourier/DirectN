using System.Runtime.InteropServices;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_RENDERING_CONTROLS
    {
        public D2D1_BUFFER_PRECISION bufferPrecision;
        public D2D1_SIZE_U tileSize;
    }
}
