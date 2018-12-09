// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12296,5)
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
        public ulong InstanceDescs { get => InteropRuntime.GetUInt64(__bits, 0, 64); set => InteropRuntime.SetUInt64(value, __bits, 0, 64); }
        public IntPtr pGeometryDescs { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public IntPtr ppGeometryDescs { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
