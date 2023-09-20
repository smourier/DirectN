// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CRYPTO_SESSION_TRANSFORM_INPUT_ARGUMENTS_0030
    {
        public D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy;
        public D3D10DDI_HRESOURCE hDrvBuffer;
        public ulong Size;
        public ulong Offset;
        public IntPtr pIV;
        public uint IVSize;
        public IntPtr pSubSampleMappingBlock;
        public uint SubSampleMappingCount;
        public IntPtr pContext;
        public ulong ContextSize;
        public D3D12DDI_CRYPTO_SESSION_TRANSFORM_DECRYPT_HEADER_INPUT_ARGUMENTS_0030 EncryptedHeader;
    }
}
