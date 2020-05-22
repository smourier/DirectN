// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(11206,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC
    {
        public Guid DecodeProfile;
        public D3D11_VDOV_DIMENSION ViewDimension;
        public D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC__union_0 __union_2;
    }
}
