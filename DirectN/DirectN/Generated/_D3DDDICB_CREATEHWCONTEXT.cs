// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(4099,9)
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
