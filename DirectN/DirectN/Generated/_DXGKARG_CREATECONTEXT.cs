// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
