// generated from <Windows SDK Path>\shared\d3dukmdt.h
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
