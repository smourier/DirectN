// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3142,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ESCAPE
    {
        public uint hAdapter;
        public uint hDevice;
        public _D3DKMT_ESCAPETYPE Type;
        public _D3DDDI_ESCAPEFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint hContext;
    }
}
