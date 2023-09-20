// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DSTATE__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint[] dwArg { get => InteropRuntime.GetArray<uint>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetArray<uint>(value, __bits, 0, 32); } }
        public float[] dvArg { get => InteropRuntime.GetArray<float>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetArray<float>(value, __bits, 0, 32); } }
    }
}
