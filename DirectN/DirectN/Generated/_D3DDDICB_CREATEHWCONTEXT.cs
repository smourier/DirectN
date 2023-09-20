// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_CREATEHWCONTEXT
    {
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATEHWCONTEXTFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public IntPtr hHwContext;
    }
}
