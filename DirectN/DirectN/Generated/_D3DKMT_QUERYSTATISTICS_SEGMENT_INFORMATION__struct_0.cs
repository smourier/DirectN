// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_SEGMENT_INFORMATION__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong PreservedDuringStandby { get => InteropRuntime.GetUInt64(__bits, 0, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 1); } }
        public ulong PreservedDuringHibernate { get => InteropRuntime.GetUInt64(__bits, 1, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 1, 1); } }
        public ulong PartiallyPreservedDuringHibernate { get => InteropRuntime.GetUInt64(__bits, 2, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 2, 1); } }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 3, 61); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 3, 61); } }
    }
}
