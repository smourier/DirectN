// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT
    {
        public D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT Output;
        public D3D11_1DDI_BUS_TYPE BusType;
        public bool AccessibleInContiguousBlocks;
        public bool AccessibleInNonContiguousBlocks;
    }
}
