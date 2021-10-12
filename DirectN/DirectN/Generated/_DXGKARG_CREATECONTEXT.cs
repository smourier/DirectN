// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1536,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATECONTEXT
    {
        public IntPtr hContext;
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _DXGK_CREATECONTEXTFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public _DXGK_CONTEXTINFO ContextInfo;
    }
}
