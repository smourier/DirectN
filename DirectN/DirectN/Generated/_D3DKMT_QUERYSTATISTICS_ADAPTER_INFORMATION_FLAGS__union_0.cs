// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_QUERYSTATISTICS_ADAPTER_INFORMATION_FLAGS__union_0__struct_0>(value, __bits, 0, 64); } }
        public ulong Value { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
