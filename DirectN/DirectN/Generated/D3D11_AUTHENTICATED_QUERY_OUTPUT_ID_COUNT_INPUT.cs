// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(10875,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_INPUT
    {
        public D3D11_AUTHENTICATED_QUERY_INPUT Input;
        public IntPtr DeviceHandle;
        public IntPtr CryptoSessionHandle;
    }
}
