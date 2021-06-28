// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(695,9)
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
