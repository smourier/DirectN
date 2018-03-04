using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICDdsFormatInfo
    {
        public DXGI_FORMAT DxgiFormat;
        public int BytesPerBlock;
        public int BlockWidth;
        public int BlockHeight;
    }
}
