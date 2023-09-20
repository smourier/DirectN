// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// All parameters related to pushing a layer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_LAYER_PARAMETERS1
    {
        public D2D_RECT_F contentBounds;
        public IntPtr geometricMask;
        public D2D1_ANTIALIAS_MODE maskAntialiasMode;
        public D2D_MATRIX_3X2_F maskTransform;
        public float opacity;
        public IntPtr opacityBrush;
        public D2D1_LAYER_OPTIONS1 layerOptions;
    }
}
