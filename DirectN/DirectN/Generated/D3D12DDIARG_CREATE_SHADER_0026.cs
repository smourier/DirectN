// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(5467,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_SHADER_0026
    {
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public IntPtr pShaderCode;
        public D3D12DDIARG_CREATE_SHADER_0026__union_0 IOSignatures;
        public D3D12DDI_CREATE_SHADER_FLAGS Flags;
        public D3D12DDI_LIBRARY_REFERENCE_0010 LibraryReference;
        public D3D12DDI_SHADERCACHE_HASH ShaderCodeHash;
    }
}
