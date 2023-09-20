// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYADAPTERINFO
    {
        public uint hAdapter;
        public _KMTQUERYADAPTERINFOTYPE Type;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
