// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICB_DEALLOCATE_0022
    {
        public IntPtr hResource;
        public uint NumAllocations;
        public IntPtr HandleList;
        public D3D12DDI_DEALLOCATE_FLAGS_0022 Flags;
    }
}
