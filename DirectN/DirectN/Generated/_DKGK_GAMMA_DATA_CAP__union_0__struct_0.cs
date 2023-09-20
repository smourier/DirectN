// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DKGK_GAMMA_DATA_CAP__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint BitCountOfInteger { get => InteropRuntime.GetUInt32(__bits, 0, 6); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt32(value, __bits, 0, 6); } }
        public uint BitCountOfFraction { get => InteropRuntime.GetUInt32(__bits, 6, 6); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt32(value, __bits, 6, 6); } }
    }
}
