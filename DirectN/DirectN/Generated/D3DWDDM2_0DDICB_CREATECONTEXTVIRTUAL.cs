// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDICB_CREATECONTEXTVIRTUAL
    {
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATECONTEXTFLAGS Flags;
        public uint ContextTypeFlags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hContext;
    }
}
