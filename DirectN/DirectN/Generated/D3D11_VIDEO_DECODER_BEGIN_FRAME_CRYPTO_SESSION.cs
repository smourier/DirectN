// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11_1.h(2548,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION
    {
        public IntPtr pCryptoSession;
        public uint BlobSize;
        public IntPtr pBlob;
        public IntPtr pKeyInfoId;
        public uint PrivateDataSize;
        public IntPtr pPrivateData;
    }
}
