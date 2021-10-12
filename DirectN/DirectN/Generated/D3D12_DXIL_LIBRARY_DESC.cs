// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13016,9)
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
