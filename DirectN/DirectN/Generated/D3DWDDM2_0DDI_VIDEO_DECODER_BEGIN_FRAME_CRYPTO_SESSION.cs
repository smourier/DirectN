// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(4077,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION
    {
        public D3D11_1DDI_HCRYPTOSESSION hCryptoSession;
        public IntPtr pBlob;
        public uint BlobSize;
        public IntPtr pKeyInfoId;
        public IntPtr pPrivateData;
        public uint PrivateDataSize;
    }
}
