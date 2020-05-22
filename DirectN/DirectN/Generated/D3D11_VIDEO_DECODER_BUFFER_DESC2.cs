// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11_4.h(3520,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_BUFFER_DESC2
    {
        public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
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
