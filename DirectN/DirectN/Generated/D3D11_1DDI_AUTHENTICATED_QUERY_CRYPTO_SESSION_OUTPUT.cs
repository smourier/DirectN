// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT
    {
        public D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT Output;
        public IntPtr DecodeHandle;
        public IntPtr CryptoSessionHandle;
        public IntPtr DeviceHandle;
    }
}
