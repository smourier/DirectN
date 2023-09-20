// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_ESCAPE
    {
        public IntPtr hDevice;
        public _D3DDDI_ESCAPEFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hContext;
    }
}
