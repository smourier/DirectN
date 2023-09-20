// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong NumberOfMemoryGroups { get => InteropRuntime.GetUInt64(__bits, 0, 2); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 2); } }
        public ulong SupportsDemotion { get => InteropRuntime.GetUInt64(__bits, 2, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 2, 1); } }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 3, 61); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 3, 61); } }
    }
}
