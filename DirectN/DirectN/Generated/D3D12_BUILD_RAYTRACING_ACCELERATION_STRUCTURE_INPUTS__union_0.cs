// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong InstanceDescs { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public IntPtr pGeometryDescs { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr ppGeometryDescs { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
