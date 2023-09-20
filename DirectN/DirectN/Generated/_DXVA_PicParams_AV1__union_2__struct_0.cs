// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__union_2__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte frame_type { get => InteropRuntime.GetByte(__bits, 0, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 2); } }
        public byte show_frame { get => InteropRuntime.GetByte(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte showable_frame { get => InteropRuntime.GetByte(__bits, 3, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 1); } }
        public byte subsampling_x { get => InteropRuntime.GetByte(__bits, 4, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        public byte subsampling_y { get => InteropRuntime.GetByte(__bits, 5, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte mono_chrome { get => InteropRuntime.GetByte(__bits, 6, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 1); } }
        public byte Reserved { get => InteropRuntime.GetByte(__bits, 7, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 7, 1); } }
    }
}
