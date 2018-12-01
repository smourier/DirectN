// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12296,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public ulong InstanceDescs => InteropRuntime.GetUInt64Bits(__bits, 0, 64);
        public IntPtr pGeometryDescs => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr ppGeometryDescs => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
