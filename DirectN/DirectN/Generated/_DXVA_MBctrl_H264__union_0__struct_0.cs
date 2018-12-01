// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(824,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public uint bSliceID => InteropRuntime.GetUInt32Bits(__bits, 0, 8);
        public uint MbType5Bits => InteropRuntime.GetUInt32Bits(__bits, 8, 5);
        public uint IntraMbFlag => InteropRuntime.GetUInt32Bits(__bits, 13, 1);
        public uint mb_field_decoding_flag => InteropRuntime.GetUInt32Bits(__bits, 14, 1);
        public uint transform_size_8x8_flag => InteropRuntime.GetUInt32Bits(__bits, 15, 1);
        public uint HostResidDiff => InteropRuntime.GetUInt32Bits(__bits, 16, 1);
        public uint DcBlockCodedCrFlag => InteropRuntime.GetUInt32Bits(__bits, 17, 1);
        public uint DcBlockCodedCbFlag => InteropRuntime.GetUInt32Bits(__bits, 18, 1);
        public uint DcBlockCodedYFlag => InteropRuntime.GetUInt32Bits(__bits, 19, 1);
        public uint FilterInternalEdgesFlag => InteropRuntime.GetUInt32Bits(__bits, 20, 1);
        public uint FilterLeftMbEdgeFlag => InteropRuntime.GetUInt32Bits(__bits, 21, 1);
        public uint FilterTopMbEdgeFlag => InteropRuntime.GetUInt32Bits(__bits, 22, 1);
        public uint ReservedBit => InteropRuntime.GetUInt32Bits(__bits, 23, 1);
        public uint bMvQuantity => InteropRuntime.GetUInt32Bits(__bits, 24, 8);
    }
}
