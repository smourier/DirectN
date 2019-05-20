// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1951,9)
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
