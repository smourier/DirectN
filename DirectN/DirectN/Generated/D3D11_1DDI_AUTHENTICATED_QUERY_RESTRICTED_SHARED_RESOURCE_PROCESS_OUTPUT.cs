// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT
    {
        public D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT Output;
        public uint ProcessIndex;
        public D3D11_1DDI_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessIdentifier;
        public IntPtr ProcessHandle;
    }
}
