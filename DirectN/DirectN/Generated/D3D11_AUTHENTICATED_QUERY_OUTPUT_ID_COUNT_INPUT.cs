// generated from <Windows SDK Path>\um\d3d11.h
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
