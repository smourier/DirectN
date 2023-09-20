// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_QUERYADAPTERINFO2
    {
        public _D3DDDI_QUERYADAPTERTYPE QueryType;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
