// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWONEINDEXEDPRIMITIVEDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public _D3DPRIMITIVETYPE PrimitiveType;
        public _D3DHAL_DRAWONEINDEXEDPRIMITIVEDATA__union_0 __union_3;
        public IntPtr lpvVertices;
        public uint dwNumVertices;
        public IntPtr lpwIndices;
        public uint dwNumIndices;
        public HRESULT ddrval;
    }
}
