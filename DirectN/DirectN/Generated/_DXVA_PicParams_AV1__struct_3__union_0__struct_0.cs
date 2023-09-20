// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_3__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte mode_ref_delta_enabled { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte mode_ref_delta_update { get => InteropRuntime.GetByte(__bits, 1, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 1); } }
        public byte delta_lf_multi { get => InteropRuntime.GetByte(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte delta_lf_present { get => InteropRuntime.GetByte(__bits, 3, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 1); } }
        public byte Reserved { get => InteropRuntime.GetByte(__bits, 4, 4); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 4); } }
    }
}
