// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWONEPRIMITIVEDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public _D3DPRIMITIVETYPE PrimitiveType;
        public _D3DHAL_DRAWONEPRIMITIVEDATA__union_0 __union_3;
        public IntPtr lpvVertices;
        public uint dwNumVertices;
        public uint dwReserved;
        public HRESULT ddrval;
    }
}
