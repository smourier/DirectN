// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_DECODER_DESC
    {
        public Guid Guid;
        public uint SampleWidth;
        public uint SampleHeight;
        public DXGI_FORMAT OutputFormat;
    }
}
