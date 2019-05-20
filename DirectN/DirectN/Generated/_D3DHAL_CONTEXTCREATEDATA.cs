// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dhal.h(445,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA
    {
        public _D3DHAL_CONTEXTCREATEDATA__union_0 __union_0;
        public _D3DHAL_CONTEXTCREATEDATA__union_1 __union_1;
        public _D3DHAL_CONTEXTCREATEDATA__union_2 __union_2;
        public _D3DHAL_CONTEXTCREATEDATA__union_3 __union_3;
        public IntPtr dwhContext;
        public HRESULT ddrval;
    }
}
