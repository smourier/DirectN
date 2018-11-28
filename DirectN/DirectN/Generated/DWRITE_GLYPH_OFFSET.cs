using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_OFFSET
    {
        public float advanceOffset;
        public float ascenderOffset;
    }
}
