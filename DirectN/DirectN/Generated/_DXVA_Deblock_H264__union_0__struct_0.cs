// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(898,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Deblock_H264__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] __bits;
        public byte ReservedBit => InteropRuntime.GetByteBits(__bits, 0, 1);
        public byte FieldModeCurrentMbFlag => InteropRuntime.GetByteBits(__bits, 1, 1);
        public byte FieldModeLeftMbFlag => InteropRuntime.GetByteBits(__bits, 2, 1);
        public byte FieldModeAboveMbFlag => InteropRuntime.GetByteBits(__bits, 3, 1);
        public byte FilterInternal8x8EdgesFlag => InteropRuntime.GetByteBits(__bits, 4, 1);
        public byte FilterInternal4x4EdgesFlag => InteropRuntime.GetByteBits(__bits, 5, 1);
        public byte FilterLeftMbEdgeFlag => InteropRuntime.GetByteBits(__bits, 6, 1);
        public byte FilterTopMbEdgeFlag => InteropRuntime.GetByteBits(__bits, 7, 1);
    }
}
