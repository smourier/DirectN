// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(10844,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_DECRYPTION_ARGUMENTS_0030
    {
        public D3D12DDI_HCRYPTOSESSIONPOLICY_0030 hDrvCryptoSessionPolicy;
        public IntPtr pIV;
        public uint IVSize;
        public IntPtr pSubSampleMappingBlock;
        public uint SubSampleMappingCount;
    }
}
