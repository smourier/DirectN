// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(4595,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_4DDI_VIDEO_DECODER_BUFFER_DESC
    {
        public D3D10DDI_HRESOURCE hResource;
        public D3D11_DDI_VIDEO_DECODER_BUFFER_TYPE BufferType;
        public uint DataOffset;
        public uint DataSize;
        public IntPtr pIV;
        public uint IVSize;
        public IntPtr pSubSampleMappingBlock;
        public uint SubSampleMappingCount;
        public uint cBlocksStripeEncrypted;
        public uint cBlocksStripeClear;
    }
}
