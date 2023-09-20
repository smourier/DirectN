// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2RENDERSTATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float dvState { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        public uint dwState { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
