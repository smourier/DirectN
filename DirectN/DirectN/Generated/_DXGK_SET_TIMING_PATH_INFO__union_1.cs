// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_SET_TIMING_PATH_INFO__union_1__struct_0 Input { get => InteropRuntime.Get<_DXGK_SET_TIMING_PATH_INFO__union_1__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_SET_TIMING_PATH_INFO__union_1__struct_0>(value, __bits, 0, 32); } }
        public uint InputFlags { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
