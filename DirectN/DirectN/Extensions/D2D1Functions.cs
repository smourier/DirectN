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
            return new D2D_SIZE_F(dpi.width / 96, dpi.height / 96);
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
#if DEBUG
            //op.debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_INFORMATION;
#endif
            if (options.HasValue)
            {
                op.debugLevel = options.Value.debugLevel;
            }
            D2D1CreateFactory(type, typeof(T).GUID, ref op, out object factory).ThrowOnError();

#if DEBUG
            // this will:
            // 1) display a message in output
            // 2) raise a breakpoint

            if (IntPtr.Size == 8)
            {
                var ptr = GetModuleHandle("d2d1.dll");

                // d2d1 (00007ffd`d8b00000)
                // d2d1!g_dimageBreakLevel (00007ffd`d90756ac)‬ => 5756AC
                // d2d1!g_dimageTraceLevel (00007ffd`d90756b0) => 5756B0

                Marshal.WriteInt32(ptr + 0x5756AC, -1);
                Marshal.WriteInt32(ptr + 0x5756B0, -1);
            }
#endif
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
        public static float PointsToDips(float pt) => 96 / (72 * pt);
        public static float DipsToPoints(float dip) => 72 / (96 * dip);
        public static float PointsToTwips(float pt) => pt * 20;
        public static float TwipsToPoints(float twips) => twips * 20;

        public static double PixelsToDips(int pixels, double dpi) => pixels * 96 / dpi;
        public static int DipsToPixels(int dips, double dpi) => (int)(dips * dpi / 96);
        public static float PixelsToDips(int pixels, float dpi) => pixels * 96 / dpi;
        public static int DipsToPixels(int dips, float dpi) => (int)(dips * dpi / 96);
    }
}
