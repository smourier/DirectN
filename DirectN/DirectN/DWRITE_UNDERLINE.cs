using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_UNDERLINE
    {
        public float width;
        public float thickness;
        public float offset;
        public float runHeight;
        public DWRITE_READING_DIRECTION readingDirection;
        public DWRITE_FLOW_DIRECTION flowDirection;
        public string localeName;
        public DWRITE_MEASURING_MODE measuringMode;
    };
}
