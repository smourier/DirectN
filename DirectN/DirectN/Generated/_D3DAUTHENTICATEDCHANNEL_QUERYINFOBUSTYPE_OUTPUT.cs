// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT
    {
        public _D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
        public _D3DBUSTYPE BusType;
        public bool bAccessibleInContiguousBlocks;
        public bool bAccessibleInNonContiguousBlocks;
    }
}
