﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(11268,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_COUNT_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public uint RestrictedSharedResourceProcessCount;
    }
}
