// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4818,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_ENTRY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong GpuTimeStamp { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public uint OperationType { get => InteropRuntime.GetUInt32(__bits, 64, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 64, 32); } }
        public uint ReservedOperationTypeBits { get => InteropRuntime.GetUInt32(__bits, 96, 32); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt32(value, __bits, 96, 32); } }
        public _DXGK_SCHEDULING_LOG_ENTRY__union_0 __union_3 { get => InteropRuntime.Get<_DXGK_SCHEDULING_LOG_ENTRY__union_0>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXGK_SCHEDULING_LOG_ENTRY__union_0>(value, __bits, 0, 128); } }
    }
}
