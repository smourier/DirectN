// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_ENCRYPTIONBLT
    {
        public IntPtr hCryptoSession;
        public IntPtr hSrcResource;
        public uint SrcSubResourceIndex;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public uint DstResourceSize;
        public IntPtr pIV;
    }
}
