// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_5__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte damping { get => InteropRuntime.GetByte(__bits, 0, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 2); } }
        public byte bits { get => InteropRuntime.GetByte(__bits, 2, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 2); } }
        public byte Reserved { get => InteropRuntime.GetByte(__bits, 4, 4); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 4); } }
    }
}
