// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10877,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public uint ProcessIndex;
        public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier;
        public IntPtr ProcessHandle;
    }
}
