// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
