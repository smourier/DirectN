// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_LIBRARY_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint FunctionCount;
    }
}
