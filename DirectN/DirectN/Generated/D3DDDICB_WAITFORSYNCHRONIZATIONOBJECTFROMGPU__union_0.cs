// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_WAITFORSYNCHRONIZATIONOBJECTFROMGPU__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr MonitoredFenceValueArray { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public ulong FenceValue { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public ulong[] Reserved { get => InteropRuntime.GetArray<ulong>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetArray<ulong>(value, __bits, 0, 512); } }
    }
}
