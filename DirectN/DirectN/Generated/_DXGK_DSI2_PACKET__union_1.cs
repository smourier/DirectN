// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DSI2_PACKET__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_DSI2_PACKET__union_1__struct_0 __field_0 { get => InteropRuntime.Get<_DXGK_DSI2_PACKET__union_1__struct_0>(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.Set<_DXGK_DSI2_PACKET__union_1__struct_0>(value, __bits, 0, 16); } }
        public uint LongWriteWordCount { get => InteropRuntime.GetUInt32(__bits, 0, 16); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt32(value, __bits, 0, 16); } }
    }
}
