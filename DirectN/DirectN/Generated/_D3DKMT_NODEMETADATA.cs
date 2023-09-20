// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
