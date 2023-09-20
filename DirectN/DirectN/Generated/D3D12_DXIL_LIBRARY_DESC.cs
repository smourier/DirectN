// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DXIL_LIBRARY_DESC
    {
        public D3D12_SHADER_BYTECODE DXILLibrary;
        public uint NumExports;
        public IntPtr pExports;
    }
}
