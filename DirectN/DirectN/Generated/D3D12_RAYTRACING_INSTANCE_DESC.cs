// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12470,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_INSTANCE_DESC
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float[] Transform { get => InteropRuntime.GetArray<float>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetArray<float>(value, __bits, 0, 384); } }
        public uint InstanceID { get => InteropRuntime.GetUInt32(__bits, 384, 24); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt32(value, __bits, 384, 24); } }
        public uint InstanceMask { get => InteropRuntime.GetUInt32(__bits, 408, 8); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt32(value, __bits, 408, 8); } }
        public uint InstanceContributionToHitGroupIndex { get => InteropRuntime.GetUInt32(__bits, 416, 24); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt32(value, __bits, 416, 24); } }
        public uint Flags { get => InteropRuntime.GetUInt32(__bits, 440, 8); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt32(value, __bits, 440, 8); } }
        public ulong AccelerationStructure { get => InteropRuntime.GetUInt64(__bits, 448, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt64(value, __bits, 448, 64); } }
    }
}
