// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_4__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte delta_q_present { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte delta_q_res { get => InteropRuntime.GetByte(__bits, 1, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 2); } }
        public byte Reserved { get => InteropRuntime.GetByte(__bits, 3, 5); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 5); } }
    }
}
