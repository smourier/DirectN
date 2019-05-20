// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1179,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_PRIVATEBUFFER
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public uint DataOffset;
        public uint DataSize;
    }
}
