// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIEW_INSTANCING_DESC
    {
        public uint ViewInstanceCount;
        public IntPtr pViewInstanceLocations;
        public D3D12_VIEW_INSTANCING_FLAGS Flags;
    }
}
