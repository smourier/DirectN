// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(654,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_UNLOCKASYNC
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDI_UNLOCKASYNCFLAGS Flags;
    }
}
