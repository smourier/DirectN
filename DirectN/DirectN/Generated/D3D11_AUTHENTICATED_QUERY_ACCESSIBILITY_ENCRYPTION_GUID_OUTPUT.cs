// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(10943,9)
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
