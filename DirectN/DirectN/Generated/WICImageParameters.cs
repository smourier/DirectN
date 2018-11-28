using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICImageParameters
    {
        public D2D1_PIXEL_FORMAT PixelFormat;
        public float DpiX;
        public float DpiY;
        public float Top;
        public float Left;
        public int PixelWidth;
        public int PixelHeight;
    }
}
