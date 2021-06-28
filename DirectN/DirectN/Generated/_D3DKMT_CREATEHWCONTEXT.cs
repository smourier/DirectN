// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(4189,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEHWCONTEXT
    {
        public uint hDevice;
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATEHWCONTEXTFLAGS Flags;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
        public uint hHwContext;
    }
}
