// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2418,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_COMMAND_SIGNATURE_0001
    {
        public uint ByteStride;
        public uint NumArgumentDescs;
        public IntPtr pArgumentDescs;
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public uint NodeMask;
    }
}
