// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_STATE_OBJECT_DESC
    {
        public D3D12_STATE_OBJECT_TYPE Type;
        public uint NumSubobjects;
        public IntPtr pSubobjects;
    }
}
