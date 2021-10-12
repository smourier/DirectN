// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3619,9)
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
