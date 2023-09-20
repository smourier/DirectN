// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
