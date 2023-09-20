// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_254__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint FileAlignment { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public int FramePitch { get => InteropRuntime.GetInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetInt32(value, __bits, 0, 32); } }
    }
}
