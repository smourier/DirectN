// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11.h(11010,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT
    {
        public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
        public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;
        public IntPtr ProcessHandle;
        public bool AllowAccess;
    }
}
