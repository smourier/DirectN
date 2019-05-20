// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(1399,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _segmentation_VP8__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte segmentation_enabled { get => InteropRuntime.GetByte(__bits, 0, 1); set => InteropRuntime.SetByte(value, __bits, 0, 1); }
        public byte update_mb_segmentation_map { get => InteropRuntime.GetByte(__bits, 1, 1); set => InteropRuntime.SetByte(value, __bits, 1, 1); }
        public byte update_mb_segmentation_data { get => InteropRuntime.GetByte(__bits, 2, 1); set => InteropRuntime.SetByte(value, __bits, 2, 1); }
        public byte mb_segement_abs_delta { get => InteropRuntime.GetByte(__bits, 3, 1); set => InteropRuntime.SetByte(value, __bits, 3, 1); }
        public byte ReservedSegmentFlags4Bits { get => InteropRuntime.GetByte(__bits, 4, 4); set => InteropRuntime.SetByte(value, __bits, 4, 4); }
    }
}
