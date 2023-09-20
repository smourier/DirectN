// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _timecode
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _timecode__struct_0 __field_0 { get => InteropRuntime.Get<_timecode__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_timecode__struct_0>(value, __bits, 0, 64); } }
        public ulong qw { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
