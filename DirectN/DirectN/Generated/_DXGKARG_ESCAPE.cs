// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_ESCAPE
    {
        public IntPtr hDevice;
        public _D3DDDI_ESCAPEFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hContext;
        public IntPtr hKmdProcessHandle;
    }
}
