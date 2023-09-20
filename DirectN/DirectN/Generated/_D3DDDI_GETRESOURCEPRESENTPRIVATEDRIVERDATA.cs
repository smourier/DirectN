// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_GETRESOURCEPRESENTPRIVATEDRIVERDATA
    {
        public uint hResource;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
