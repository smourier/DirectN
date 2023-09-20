// generated from <Windows SDK Path>\um\d3d11_1.h
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
