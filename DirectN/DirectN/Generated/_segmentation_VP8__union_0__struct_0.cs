// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1399,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _segmentation_VP8__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte segmentation_enabled => InteropRuntime.GetByteBits(__bits, 0, 1);
        public byte update_mb_segmentation_map => InteropRuntime.GetByteBits(__bits, 1, 1);
        public byte update_mb_segmentation_data => InteropRuntime.GetByteBits(__bits, 2, 1);
        public byte mb_segement_abs_delta => InteropRuntime.GetByteBits(__bits, 3, 1);
        public byte ReservedSegmentFlags4Bits => InteropRuntime.GetByteBits(__bits, 4, 4);
    }
}
