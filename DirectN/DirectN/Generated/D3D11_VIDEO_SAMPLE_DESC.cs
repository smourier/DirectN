// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11_1.h(2620,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_SAMPLE_DESC
    {
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
        public DXGI_COLOR_SPACE_TYPE ColorSpace;
    }
}
