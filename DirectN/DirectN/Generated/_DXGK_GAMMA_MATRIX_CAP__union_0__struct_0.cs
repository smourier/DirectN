// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GAMMA_MATRIX_CAP__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint MatrixSizeX { get => InteropRuntime.GetUInt32(__bits, 0, 10); set { if (__bits == null) __bits = new byte[3]; InteropRuntime.SetUInt32(value, __bits, 0, 10); } }
        public uint MatrixSizeY { get => InteropRuntime.GetUInt32(__bits, 10, 10); set { if (__bits == null) __bits = new byte[3]; InteropRuntime.SetUInt32(value, __bits, 10, 10); } }
    }
}
