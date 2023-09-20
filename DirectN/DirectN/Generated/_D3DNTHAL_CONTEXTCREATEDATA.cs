// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CONTEXTCREATEDATA
    {
        public _D3DNTHAL_CONTEXTCREATEDATA__union_0 __union_0;
        public _D3DNTHAL_CONTEXTCREATEDATA__union_1 __union_1;
        public _D3DNTHAL_CONTEXTCREATEDATA__union_2 __union_2;
        public uint dwPID;
        public IntPtr dwhContext;
        public HRESULT ddrval;
    }
}
