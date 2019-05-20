// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2043,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_BUFFERBLT1
    {
        public IntPtr hDstResource;
        public IntPtr hSrcResource;
        public uint Offset;
        public _D3DDDIRANGE SrcRange;
        public uint CopyFlags;
    }
}
