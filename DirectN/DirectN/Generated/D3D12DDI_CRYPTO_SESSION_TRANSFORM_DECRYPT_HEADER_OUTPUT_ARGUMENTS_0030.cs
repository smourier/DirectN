// generated from <Windows SDK Path>\um\d3d12umddi.h
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
