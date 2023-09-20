// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DRED_ALLOCATION_NODE
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte ObjectNameA;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string ObjectNameW;
        public D3D12_DRED_ALLOCATION_TYPE AllocationType;
        public IntPtr pNext;
    }
}
