// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_PACKET__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint DataId { get => InteropRuntime.GetUInt32(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetUInt32(value, __bits, 0, 8); } }
        public _DXGK_DSI2_PACKET__union_0__struct_0 __field_1 { get => InteropRuntime.Get<_DXGK_DSI2_PACKET__union_0__struct_0>(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.Set<_DXGK_DSI2_PACKET__union_0__struct_0>(value, __bits, 0, 8); } }
    }
}
