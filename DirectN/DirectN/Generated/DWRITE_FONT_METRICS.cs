// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(472,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_FONT_METRICS
    {
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
    }
}
