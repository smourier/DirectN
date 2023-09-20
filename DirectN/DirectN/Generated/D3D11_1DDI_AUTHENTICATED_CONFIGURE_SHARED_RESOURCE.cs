// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE
    {
        public D3D11_1DDI_AUTHENTICATED_CONFIGURE_INPUT Parameters;
        public D3D11_1DDI_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;
        public IntPtr ProcessHandle;
        public bool AllowAccess;
    }
}
