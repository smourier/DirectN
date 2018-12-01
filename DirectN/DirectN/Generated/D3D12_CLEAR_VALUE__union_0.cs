// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2407,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_CLEAR_VALUE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public float Color => InteropRuntime.GetSingleBits(__bits, 0, 128);
        public D3D12_DEPTH_STENCIL_VALUE DepthStencil => InteropRuntime.GetBits<D3D12_DEPTH_STENCIL_VALUE>(__bits, 0, 40);
    }
}
