// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(179,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2__union_0__struct_0 Fence { get => InteropRuntime.Get<_D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<_D3DKMT_SIGNALSYNCHRONIZATIONOBJECT2__union_0__struct_0>(value, __bits, 0, 64); } }
        public IntPtr CpuEventHandle { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public ulong[] Reserved { get => InteropRuntime.GetArray<ulong>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetArray<ulong>(value, __bits, 0, 512); } }
    }
}
