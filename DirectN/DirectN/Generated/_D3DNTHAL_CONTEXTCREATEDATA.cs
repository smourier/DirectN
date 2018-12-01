// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(273,9)
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
        public ulong dwhContext;
        public HRESULT ddrval;
    }
}
