// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_EVICT
    {
        public uint NumObjects;
        public IntPtr pObjects;
        public D3DDDI_EVICT_FLAGS Flags;
    }
}
