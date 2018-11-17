using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    public static class D2D1Functions
    {
        [DllImport("d2d1")]
        public static extern HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, ref D2D1_FACTORY_OPTIONS pFactoryOptions, [MarshalAs(UnmanagedType.IUnknown)] out object ppIFactory);

        [DllImport("d2d1")]
        public static extern void D2D1MakeRotateMatrix(float angle, D2D1_POINT_2F center, ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1")]
        public static extern void D2D1MakeSkewMatrix(float angleX, float angleY, D2D1_POINT_2F center, ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1")]
        public static extern bool D2D1IsMatrixInvertible(ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1")]
        public static extern bool D2D1InvertMatrix(D2D1_MATRIX_3X2_F matrix);
    }
}
