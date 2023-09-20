// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_OUTPUT_ARGUMENTS_0030
    {
        public D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_OUTPUT_ARGUMENTS_0030 Decrypt;
        public D3D12DDI_CRYPTO_SESSION_TRANSFORM_TRANSCRYPT_OUTPUT_ARGUMENTS_0030 Transcrypt;
        public D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_OUTPUT_ARGUMENTS_0030 ClearHeader;
    }
}
