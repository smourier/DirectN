using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PDF_RENDER_PARAMS
    {
        public D2D_RECT_F SourceRect;
        public int DestinationWidth;
        public int DestinationHeight;
        public _D3DCOLORVALUE BackgroundColor;
        public bool IgnoreHighContrast;
    }
}
