// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(824,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint bSliceID { get => InteropRuntime.GetUInt32(__bits, 0, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 8); } }
        public uint MbType5Bits { get => InteropRuntime.GetUInt32(__bits, 8, 5); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 8, 5); } }
        public uint IntraMbFlag { get => InteropRuntime.GetUInt32(__bits, 13, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 13, 1); } }
        public uint mb_field_decoding_flag { get => InteropRuntime.GetUInt32(__bits, 14, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 14, 1); } }
        public uint transform_size_8x8_flag { get => InteropRuntime.GetUInt32(__bits, 15, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 15, 1); } }
        public uint HostResidDiff { get => InteropRuntime.GetUInt32(__bits, 16, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 1); } }
        public uint DcBlockCodedCrFlag { get => InteropRuntime.GetUInt32(__bits, 17, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 17, 1); } }
        public uint DcBlockCodedCbFlag { get => InteropRuntime.GetUInt32(__bits, 18, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 18, 1); } }
        public uint DcBlockCodedYFlag { get => InteropRuntime.GetUInt32(__bits, 19, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 19, 1); } }
        public uint FilterInternalEdgesFlag { get => InteropRuntime.GetUInt32(__bits, 20, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 20, 1); } }
        public uint FilterLeftMbEdgeFlag { get => InteropRuntime.GetUInt32(__bits, 21, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 21, 1); } }
        public uint FilterTopMbEdgeFlag { get => InteropRuntime.GetUInt32(__bits, 22, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 22, 1); } }
        public uint ReservedBit { get => InteropRuntime.GetUInt32(__bits, 23, 1); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 23, 1); } }
        public uint bMvQuantity { get => InteropRuntime.GetUInt32(__bits, 24, 8); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 24, 8); } }
    }
}
