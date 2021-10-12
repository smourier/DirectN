// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4801,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATECONTEXTVIRTUAL
    {
        public uint hDevice;
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATECONTEXTFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public _D3DKMT_CLIENTHINT ClientHint;
        public uint hContext;
    }
}
