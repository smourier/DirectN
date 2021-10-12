// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3641,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT_ID_COUNT_OUTPUT
    {
        public D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT Output;
        public IntPtr DeviceHandle;
        public IntPtr CryptoSessionHandle;
        public uint OutputIDCount;
    }
}
