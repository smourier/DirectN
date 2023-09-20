// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_ACESSIBILITY_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public D3D11_BUS_TYPE BusType;
        public bool AccessibleInContiguousBlocks;
        public bool AccessibleInNonContiguousBlocks;
    }
}
