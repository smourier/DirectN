// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgitype.h(83,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_MODE_DESC
    {
        public uint Width;
        public uint Height;
        public DXGI_RATIONAL RefreshRate;
        public DXGI_FORMAT Format;
        public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;
        public DXGI_MODE_SCALING Scaling;
    }
}
