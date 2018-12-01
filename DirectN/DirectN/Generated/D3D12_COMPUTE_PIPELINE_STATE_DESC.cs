// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(1848,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_COMPUTE_PIPELINE_STATE_DESC
    {
        public IntPtr pRootSignature;
        public D3D12_SHADER_BYTECODE CS;
        public uint NodeMask;
        public D3D12_CACHED_PIPELINE_STATE CachedPSO;
        public D3D12_PIPELINE_STATE_FLAGS Flags;
    }
}
