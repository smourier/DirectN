// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11.h(10939,9)
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
