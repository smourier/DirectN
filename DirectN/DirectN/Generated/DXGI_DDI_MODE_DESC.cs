// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(184,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_MODE_DESC
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public DXGI_DDI_RATIONAL RefreshRate;
        public DXGI_DDI_MODE_SCANLINE_ORDER ScanlineOrdering;
        public DXGI_DDI_MODE_ROTATION Rotation;
        public DXGI_DDI_MODE_SCALING Scaling;
    }
}
