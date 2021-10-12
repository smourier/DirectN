// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1371,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROOT_SIGNATURE
    {
        public uint NumParameters;
        public IntPtr pRootParameters;
        public uint NumStaticSamplers;
        public IntPtr pStaticSamplers;
        public D3D12DDI_ROOT_SIGNATURE_FLAGS Flags;
    }
}
