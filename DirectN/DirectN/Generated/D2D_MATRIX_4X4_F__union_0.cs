// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcommon.h(352,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_4X4_F__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D2D_MATRIX_4X4_F__union_0__struct_0 __field_0 { get => InteropRuntime.Get<D2D_MATRIX_4X4_F__union_0__struct_0>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<D2D_MATRIX_4X4_F__union_0__struct_0>(value, __bits, 0, 512); } }
        public float[] m { get => InteropRuntime.GetArray<float>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.SetArray<float>(value, __bits, 0, 512); } }
    }
}
