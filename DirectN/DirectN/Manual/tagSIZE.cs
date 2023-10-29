using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSIZE
    {
        public uint width;
        public uint height;

        public tagSIZE(uint width, uint height)
        {
            this.width = width;
            this.height = height;
        }

        public tagSIZE(int width, int height)
        {
            this.width = (uint)width;
            this.height = (uint)height;
        }

        public bool IsZero => width == 0 && height == 0;
        public bool IsEmpty => width == 0 || height == 0;

        public override string ToString() => width + "," + height;
        public tagRECT ToRECT() => new tagRECT(0, 0, (int)width, (int)height);
        public D2D_SIZE_U ToD2D_SIZE_U() => new D2D_SIZE_U { width = width, height = height };
        public D2D_SIZE_F ToD2D_SIZE_F() => new D2D_SIZE_F { width = width, height = height };

        public const long HIMETRIC_PER_INCH = 2540;

        public tagSIZE PixelToHiMetric()
        {
            var dpi = D2D1Functions.Dpi;
            return new tagSIZE((uint)(HIMETRIC_PER_INCH * width / dpi.width), (uint)(HIMETRIC_PER_INCH * height / dpi.height));
        }

        public tagSIZE HiMetricToPixel()
        {
            var dpi = D2D1Functions.Dpi;
            return new tagSIZE((uint)(width * dpi.width / HIMETRIC_PER_INCH), (uint)(height * dpi.height / HIMETRIC_PER_INCH));
        }

        public D2D_SIZE_F PixelToHiMetricF()
        {
            var dpi = D2D1Functions.Dpi;
            return new D2D_SIZE_F(HIMETRIC_PER_INCH * width / dpi.width, HIMETRIC_PER_INCH * height / dpi.height);
        }

        public D2D_SIZE_F HiMetricToPixelF()
        {
            var dpi = D2D1Functions.Dpi;
            return new D2D_SIZE_F(width * dpi.width / HIMETRIC_PER_INCH, height * dpi.height / HIMETRIC_PER_INCH);
        }
    }
}
