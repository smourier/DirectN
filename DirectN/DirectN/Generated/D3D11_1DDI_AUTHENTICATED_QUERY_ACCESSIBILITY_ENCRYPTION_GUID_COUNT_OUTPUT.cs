﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3683,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_COUNT_OUTPUT
    {
        public D3D11_1DDI_AUTHENTICATED_QUERY_OUTPUT Output;
        public uint EncryptionGuidCount;
    }
}