// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(4088,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_CHECK_VIDEO_PROCESSOR_FORMAT_CONVERSION
    {
        public int InputFormat;
        public D3DDDI_COLOR_SPACE_TYPE InputColorSpace;
        public int OutputFormat;
        public D3DDDI_COLOR_SPACE_TYPE OutputColorSpace;
        public bool Supported;
    }
}
