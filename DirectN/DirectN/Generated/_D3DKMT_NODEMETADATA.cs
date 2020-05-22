// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(2133,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _D3DKMT_NODEMETADATA
    {
        public uint NodeOrdinalAndAdapterIndex;
        public _DXGK_NODEMETADATA NodeData;
    }
}
