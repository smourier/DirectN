// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_FIXED32__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVADDI_FIXED32__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVADDI_FIXED32__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXVADDI_FIXED32__union_0__struct_0>(value, __bits, 0, 32); } }
        public int ll { get => InteropRuntime.GetInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetInt32(value, __bits, 0, 32); } }
    }
}
