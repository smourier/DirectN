// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_INVALIDATEACTIVEVIDPN
    {
        public uint hAdapter;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
