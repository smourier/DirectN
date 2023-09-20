// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_PROTECTED_RESOURCE_SESSION_DESC1
    {
        public uint NodeMask;
        public D3D12_PROTECTED_RESOURCE_SESSION_FLAGS Flags;
        public Guid ProtectionType;
    }
}
