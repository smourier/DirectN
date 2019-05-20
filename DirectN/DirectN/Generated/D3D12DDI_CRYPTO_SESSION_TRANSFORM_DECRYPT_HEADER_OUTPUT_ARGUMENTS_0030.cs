// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9057,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030
    {
        public bool Enable;
        public IntPtr pSliceHeaders;
        public ulong SliceHeadersSize;
        public IntPtr pContext;
        public ulong ContextSize;
    }
}
