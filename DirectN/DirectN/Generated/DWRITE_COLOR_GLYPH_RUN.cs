// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite_2.h(768,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_COLOR_GLYPH_RUN
    {
        public DWRITE_GLYPH_RUN glyphRun;
        public IntPtr glyphRunDescription;
        public float baselineOriginX;
        public float baselineOriginY;
        public _D3DCOLORVALUE runColor;
        public ushort paletteIndex;
    }
}
