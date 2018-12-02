// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(599,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SEGMENTPREFERENCE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint SegmentId0 => InteropRuntime.GetUInt32(__bits, 0, 5);
        public uint Direction0 => InteropRuntime.GetUInt32(__bits, 5, 1);
        public uint SegmentId1 => InteropRuntime.GetUInt32(__bits, 6, 5);
        public uint Direction1 => InteropRuntime.GetUInt32(__bits, 11, 1);
        public uint SegmentId2 => InteropRuntime.GetUInt32(__bits, 12, 5);
        public uint Direction2 => InteropRuntime.GetUInt32(__bits, 17, 1);
        public uint SegmentId3 => InteropRuntime.GetUInt32(__bits, 18, 5);
        public uint Direction3 => InteropRuntime.GetUInt32(__bits, 23, 1);
        public uint SegmentId4 => InteropRuntime.GetUInt32(__bits, 24, 5);
        public uint Direction4 => InteropRuntime.GetUInt32(__bits, 29, 1);
        public uint Reserved => InteropRuntime.GetUInt32(__bits, 30, 2);
    }
}
