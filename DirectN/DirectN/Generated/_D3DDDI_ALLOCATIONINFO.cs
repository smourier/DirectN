// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_ALLOCATIONINFO
    {
        public uint hAllocation;
        public IntPtr pSystemMem;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint VidPnSourceId;
        public _D3DDDI_ALLOCATIONINFO__union_0 Flags;
    }
}
