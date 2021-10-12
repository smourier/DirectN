// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(671,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_OPENRESOURCE
    {
        public uint NumAllocations;
        public _D3DDDIARG_OPENRESOURCE__union_0 __union_1;
        public uint hKMResource;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hResource;
        public _D3DDDI_ROTATION Rotation;
        public _D3DDDI_OPENRESOURCEFLAGS Flags;
    }
}
