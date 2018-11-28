using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_METRICS
    {
        public int leftSideBearing;
        public uint advanceWidth;
        public int rightSideBearing;
        public int topSideBearing;
        public uint advanceHeight;
        public int bottomSideBearing;
        public int verticalOriginY;
    }
}
