// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_TRIMRESIDENCYSET
    {
        public D3DDDI_TRIMRESIDENCYSET_FLAGS TrimFlags;
        public ulong NumBytesToTrim;
    }
}
