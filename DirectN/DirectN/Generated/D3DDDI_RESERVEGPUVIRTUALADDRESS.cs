// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1440,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_RESERVEGPUVIRTUALADDRESS
    {
        public D3DDDI_RESERVEGPUVIRTUALADDRESS__union_0 __union_0;
        public ulong BaseAddress;
        public ulong MinimumAddress;
        public ulong MaximumAddress;
        public ulong Size;
        public D3DDDI_RESERVEGPUVIRTUALADDRESS__union_1 __union_5;
        public D3DDDI_RESERVEGPUVIRTUALADDRESS__union_2 __union_6;
        public ulong VirtualAddress;
        public D3DDDI_RESERVEGPUVIRTUALADDRESS__union_3 __union_8;
    }
}
