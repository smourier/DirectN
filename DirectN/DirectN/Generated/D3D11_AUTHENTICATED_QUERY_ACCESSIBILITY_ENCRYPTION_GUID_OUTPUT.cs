// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public uint EncryptionGuidIndex;
        public Guid EncryptionGuid;
    }
}
