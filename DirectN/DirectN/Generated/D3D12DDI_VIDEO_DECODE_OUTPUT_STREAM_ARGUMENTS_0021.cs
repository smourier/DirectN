// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0021
    {
        public D3D10DDI_HRESOURCE hDrvOutputTexture2D;
        public uint OutputSubresource;
        public D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments;
    }
}
