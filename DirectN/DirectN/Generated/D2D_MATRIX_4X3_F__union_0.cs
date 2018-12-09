// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dcommon.h(331,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_4X3_F__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D2D_MATRIX_4X3_F__union_0__struct_0 __field_0 { get => InteropRuntime.Get<D2D_MATRIX_4X3_F__union_0__struct_0>(__bits, 0, 384); set => InteropRuntime.Set<D2D_MATRIX_4X3_F__union_0__struct_0>(value, __bits, 0, 384); }
        public float[] m { get => InteropRuntime.GetArray<float>(__bits, 0, 384); set => InteropRuntime.SetArray<float>(value, __bits, 0, 384); }
    }
}
