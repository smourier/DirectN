// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dukmdt.h(609,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SEGMENTPREFERENCE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint SegmentId0 { get => InteropRuntime.GetUInt32(__bits, 0, 5); set => InteropRuntime.SetUInt32(value, __bits, 0, 5); }
        public uint Direction0 { get => InteropRuntime.GetUInt32(__bits, 5, 1); set => InteropRuntime.SetUInt32(value, __bits, 5, 1); }
        public uint SegmentId1 { get => InteropRuntime.GetUInt32(__bits, 6, 5); set => InteropRuntime.SetUInt32(value, __bits, 6, 5); }
        public uint Direction1 { get => InteropRuntime.GetUInt32(__bits, 11, 1); set => InteropRuntime.SetUInt32(value, __bits, 11, 1); }
        public uint SegmentId2 { get => InteropRuntime.GetUInt32(__bits, 12, 5); set => InteropRuntime.SetUInt32(value, __bits, 12, 5); }
        public uint Direction2 { get => InteropRuntime.GetUInt32(__bits, 17, 1); set => InteropRuntime.SetUInt32(value, __bits, 17, 1); }
        public uint SegmentId3 { get => InteropRuntime.GetUInt32(__bits, 18, 5); set => InteropRuntime.SetUInt32(value, __bits, 18, 5); }
        public uint Direction3 { get => InteropRuntime.GetUInt32(__bits, 23, 1); set => InteropRuntime.SetUInt32(value, __bits, 23, 1); }
        public uint SegmentId4 { get => InteropRuntime.GetUInt32(__bits, 24, 5); set => InteropRuntime.SetUInt32(value, __bits, 24, 5); }
        public uint Direction4 { get => InteropRuntime.GetUInt32(__bits, 29, 1); set => InteropRuntime.SetUInt32(value, __bits, 29, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 30, 2); set => InteropRuntime.SetUInt32(value, __bits, 30, 2); }
    }
}
