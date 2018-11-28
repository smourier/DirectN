using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_LAYER_PARAMETERS1
    {
        public D2D1_RECT_F contentBounds;
        public ID2D1Geometry geometricMask;
        public D2D1_ANTIALIAS_MODE maskAntialiasMode;
        public D2D1_MATRIX_3X2_F maskTransform;
        public float opacity;
        public ID2D1Brush opacityBrush;
        public D2D1_LAYER_OPTIONS1 layerOptions;
    }
}
