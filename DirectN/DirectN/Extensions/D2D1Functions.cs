using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    public static class D2D1Functions
    {
        private static readonly Lazy<D2D_SIZE_F> _dpi = new Lazy<D2D_SIZE_F>(GetDesktopDpi, true);
        public static D2D_SIZE_F Dpi => _dpi.Value;

        private static readonly Lazy<D2D_SIZE_F> _dpiScale = new Lazy<D2D_SIZE_F>(() =>
        {
            var dpi = Dpi;
            return new D2D_SIZE_F(dpi.width / DpiUtilities.USER_DEFAULT_SCREEN_DPI, dpi.height / DpiUtilities.USER_DEFAULT_SCREEN_DPI);
        }, true);
        public static D2D_SIZE_F DpiScale => _dpiScale.Value;

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1SinCos(float angle, out float s, out float c);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern float D2D1Vec3Length(float x, float y, float z);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern float D2D1Tan(float angle);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern _D3DCOLORVALUE D2D1ConvertColorSpace(D2D1_COLOR_SPACE sourceColorSpace, D2D1_COLOR_SPACE destinationColorSpace, ref _D3DCOLORVALUE color);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern HRESULT D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, ref D2D1_FACTORY_OPTIONS pFactoryOptions, [MarshalAs(UnmanagedType.IUnknown)] out object ppIFactory);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeRotateMatrix(float angle, D2D1_POINT_2F center, ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeSkewMatrix(float angleX, float angleY, D2D1_POINT_2F center, ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern bool D2D1IsMatrixInvertible(ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern bool D2D1InvertMatrix(ref D2D1_MATRIX_3X2_F matrix);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        public static IComObject<ID2D1Factory> D2D1CreateFactory(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null) => D2D1CreateFactory<ID2D1Factory>(type, options);
        public static IComObject<ID2D1Factory1> D2D1CreateFactory1(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null) => D2D1CreateFactory<ID2D1Factory1>(type, options);
        public static IComObject<T> D2D1CreateFactory<T>(D2D1_FACTORY_TYPE type = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_MULTI_THREADED, D2D1_FACTORY_OPTIONS? options = null)
        {
            var op = new D2D1_FACTORY_OPTIONS();
            if (options.HasValue)
            {
                op.debugLevel = options.Value.debugLevel;
            }
            D2D1CreateFactory(type, typeof(T).GUID, ref op, out object factory).ThrowOnError();
            return new ComObject<T>((T)factory);
        }

        // https://docs.microsoft.com/en-us/windows/win32/learnwin32/dpi-and-device-independent-pixels
        public static D2D_SIZE_F GetDesktopDpi()
        {
            using (var fac = D2D1CreateFactory())
            {
                fac.Object.GetDesktopDpi(out var x, out var y);
                return new D2D_SIZE_F(x, y);
            }
        }

        // https://blogs.msdn.microsoft.com/text/2009/12/11/wpf-text-measurement-units/
        public static float PointsToDips(float pt) => DpiUtilities.USER_DEFAULT_SCREEN_DPI / (72 * pt);
        public static float DipsToPoints(float dip) => 72 / (DpiUtilities.USER_DEFAULT_SCREEN_DPI * dip);
        public static float PointsToTwips(float pt) => pt * 20;
        public static float TwipsToPoints(float twips) => twips / 20;

        public static double PixelsToDips(int pixels, double dpi) => pixels * DpiUtilities.USER_DEFAULT_SCREEN_DPI / dpi;
        public static int DipsToPixels(int dips, double dpi) => (int)(dips * dpi / DpiUtilities.USER_DEFAULT_SCREEN_DPI);
        public static float PixelsToDips(int pixels, float dpi) => pixels * DpiUtilities.USER_DEFAULT_SCREEN_DPI / dpi;
        public static int DipsToPixels(int dips, float dpi) => (int)(dips * dpi / DpiUtilities.USER_DEFAULT_SCREEN_DPI);
    }
}
