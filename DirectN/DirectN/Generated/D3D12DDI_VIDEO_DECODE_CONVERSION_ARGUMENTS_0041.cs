// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11275,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0041
    {
        public bool Enable;
        public D3D10DDI_HRESOURCE hDrvReferenceTexture2D;
        public uint ReferenceSubresource;
        public DXGI_COLOR_SPACE_TYPE OutputColorSpace;
        public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;
        public uint OutputWidth;
        public uint OutputHeight;
    }
}
