// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_96__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort Counter { get => InteropRuntime.GetUInt16(__bits, 0, 11); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 0, 11); } }
        public ushort Reserved { get => InteropRuntime.GetUInt16(__bits, 11, 5); set { if (__bits == null) __bits = new byte[2]; InteropRuntime.SetUInt16(value, __bits, 11, 5); } }
    }
}
