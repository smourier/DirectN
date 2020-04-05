// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(1321,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _segmentation_VP9__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte enabled { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte update_map { get => InteropRuntime.GetByte(__bits, 1, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 1); } }
        public byte temporal_update { get => InteropRuntime.GetByte(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte abs_delta { get => InteropRuntime.GetByte(__bits, 3, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 1); } }
        public byte ReservedSegmentFlags4Bits { get => InteropRuntime.GetByte(__bits, 4, 4); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 4); } }
    }
}
