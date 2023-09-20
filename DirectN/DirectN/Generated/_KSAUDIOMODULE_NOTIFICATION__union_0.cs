// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSAUDIOMODULE_NOTIFICATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _KSAUDIOMODULE_NOTIFICATION__union_0__struct_0 ProviderId { get => InteropRuntime.Get<_KSAUDIOMODULE_NOTIFICATION__union_0__struct_0>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<_KSAUDIOMODULE_NOTIFICATION__union_0__struct_0>(value, __bits, 0, 320); } }
        public long Alignment { get => InteropRuntime.GetInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.SetInt64(value, __bits, 0, 64); } }
    }
}
