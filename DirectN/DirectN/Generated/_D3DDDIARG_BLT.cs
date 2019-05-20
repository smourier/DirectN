// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(777,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_BLT
    {
        public IntPtr hSrcResource;
        public uint SrcSubResourceIndex;
        public tagRECT SrcRect;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public tagRECT DstRect;
        public uint ColorKey;
        public _D3DDDI_BLTFLAGS Flags;
    }
}
