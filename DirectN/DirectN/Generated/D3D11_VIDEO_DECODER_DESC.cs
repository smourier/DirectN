// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(9667,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_DESC
    {
        public Guid Guid;
        public uint SampleWidth;
        public uint SampleHeight;
        public DXGI_FORMAT OutputFormat;
    }
}
