// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(866,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_KERNELOVERLAYINFO
    {
        public uint hAllocation;
        public _D3DDDIRECT DstRect;
        public _D3DDDIRECT SrcRect;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
