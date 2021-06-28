// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(10789,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT
    {
        public D3D11_OMAC omac;
        public Guid QueryType;
        public IntPtr hChannel;
        public uint SequenceNumber;
        public HRESULT ReturnCode;
    }
}
