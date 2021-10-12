// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(11325,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public IntPtr DeviceHandle;
        public IntPtr CryptoSessionHandle;
        public uint OutputIDIndex;
        public ulong OutputID;
    }
}
