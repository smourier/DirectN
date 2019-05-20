// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1348,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEHWCONTEXT
    {
        public IntPtr hHwContext;
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATEHWCONTEXTFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public _DXGK_HWCONTEXT_CAPS ContextCaps;
    }
}
