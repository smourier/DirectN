// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12269,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_INSTANCE_DESC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] __bits;
        public float[] Transform => InteropRuntime.GetArray<float>(__bits, 0, 384);
        public uint InstanceID => InteropRuntime.GetUInt32(__bits, 384, 24);
        public uint InstanceMask => InteropRuntime.GetUInt32(__bits, 408, 8);
        public uint InstanceContributionToHitGroupIndex => InteropRuntime.GetUInt32(__bits, 416, 24);
        public uint Flags => InteropRuntime.GetUInt32(__bits, 440, 8);
        public ulong AccelerationStructure => InteropRuntime.GetUInt6s(__bits, 448, 64);
    }
}
