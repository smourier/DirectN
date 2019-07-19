// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(2144,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATERESOURCE
    {
        public IntPtr pMipInfoList;
        public IntPtr pInitialDataUP;
        public D3D10DDIRESOURCE_TYPE ResourceDimension;
        public uint Usage;
        public uint BindFlags;
        public uint MapFlags;
        public uint MiscFlags;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
        public uint MipLevels;
        public uint ArraySize;
        public IntPtr pPrimaryDesc;
        public uint ByteStride;
        public D3D11_DDI_VIDEO_DECODER_BUFFER_TYPE DecoderBufferType;
        public D3DWDDM2_0DDI_TEXTURE_LAYOUT TextureLayout;
    }
}
