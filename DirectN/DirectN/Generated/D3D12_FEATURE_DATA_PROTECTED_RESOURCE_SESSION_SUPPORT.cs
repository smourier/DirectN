// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT
    {
        public uint NodeIndex;
        public D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS Support;
    }
}
