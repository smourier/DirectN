// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public IntPtr DecoderHandle;
        public IntPtr CryptoSessionHandle;
        public IntPtr DeviceHandle;
    }
}
