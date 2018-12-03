// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(547,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_METRICS
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
