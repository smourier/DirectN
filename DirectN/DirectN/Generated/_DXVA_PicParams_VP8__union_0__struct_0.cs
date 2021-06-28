// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1425,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_VP8__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte frame_type { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte version { get => InteropRuntime.GetByte(__bits, 1, 3); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 3); } }
        public byte show_frame { get => InteropRuntime.GetByte(__bits, 4, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        public byte clamp_type { get => InteropRuntime.GetByte(__bits, 5, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte ReservedFrameTag3Bits { get => InteropRuntime.GetByte(__bits, 6, 2); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 2); } }
    }
}
