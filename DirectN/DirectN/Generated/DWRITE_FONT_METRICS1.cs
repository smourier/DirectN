// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(627,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_METRICS1
    {
        // struct DWRITE_FONT_METRICS
        public ushort designUnitsPerEm;
        public ushort ascent;
        public ushort descent;
        public short lineGap;
        public ushort capHeight;
        public ushort xHeight;
        public short underlinePosition;
        public ushort underlineThickness;
        public short strikethroughPosition;
        public ushort strikethroughThickness;
        
        // DWRITE_FONT_METRICS1
        public short glyphBoxLeft;
        public short glyphBoxTop;
        public short glyphBoxRight;
        public short glyphBoxBottom;
        public short subscriptPositionX;
        public short subscriptPositionY;
        public short subscriptSizeX;
        public short subscriptSizeY;
        public short superscriptPositionX;
        public short superscriptPositionY;
        public short superscriptSizeX;
        public short superscriptSizeY;
        public bool hasTypographicMetrics;
    }
}
