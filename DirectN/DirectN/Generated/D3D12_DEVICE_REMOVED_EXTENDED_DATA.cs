// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA
    {
        public D3D12_DRED_FLAGS Flags;
        public IntPtr pHeadAutoBreadcrumbNode;
    }
}
