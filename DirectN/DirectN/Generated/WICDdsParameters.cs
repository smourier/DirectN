using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICDdsParameters
    {
        public int Width;
        public int Height;
        public int Depth;
        public int MipLevels;
        public int ArraySize;
        public DXGI_FORMAT DxgiFormat;
        public WICDdsDimension Dimension;
        public WICDdsAlphaMode AlphaMode;
    }
}
