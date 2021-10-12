// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3413,9)
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
