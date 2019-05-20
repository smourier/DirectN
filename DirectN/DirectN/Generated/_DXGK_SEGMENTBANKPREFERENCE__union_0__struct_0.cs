// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(56,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTBANKPREFERENCE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Bank0 { get => InteropRuntime.GetUInt32(__bits, 0, 7); set => InteropRuntime.SetUInt32(value, __bits, 0, 7); }
        public uint Direction0 { get => InteropRuntime.GetUInt32(__bits, 7, 1); set => InteropRuntime.SetUInt32(value, __bits, 7, 1); }
        public uint Bank1 { get => InteropRuntime.GetUInt32(__bits, 8, 7); set => InteropRuntime.SetUInt32(value, __bits, 8, 7); }
        public uint Direction1 { get => InteropRuntime.GetUInt32(__bits, 15, 1); set => InteropRuntime.SetUInt32(value, __bits, 15, 1); }
        public uint Bank2 { get => InteropRuntime.GetUInt32(__bits, 16, 7); set => InteropRuntime.SetUInt32(value, __bits, 16, 7); }
        public uint Direction2 { get => InteropRuntime.GetUInt32(__bits, 23, 1); set => InteropRuntime.SetUInt32(value, __bits, 23, 1); }
        public uint Bank3 { get => InteropRuntime.GetUInt32(__bits, 24, 7); set => InteropRuntime.SetUInt32(value, __bits, 24, 7); }
        public uint Direction3 { get => InteropRuntime.GetUInt32(__bits, 31, 1); set => InteropRuntime.SetUInt32(value, __bits, 31, 1); }
    }
}
