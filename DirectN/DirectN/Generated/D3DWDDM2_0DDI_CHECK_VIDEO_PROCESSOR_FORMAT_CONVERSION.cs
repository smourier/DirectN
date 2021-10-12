// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(4094,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_CHECK_VIDEO_PROCESSOR_FORMAT_CONVERSION
    {
        public DXGI_FORMAT InputFormat;
        public D3DDDI_COLOR_SPACE_TYPE InputColorSpace;
        public DXGI_FORMAT OutputFormat;
        public D3DDDI_COLOR_SPACE_TYPE OutputColorSpace;
        public bool Supported;
    }
}
