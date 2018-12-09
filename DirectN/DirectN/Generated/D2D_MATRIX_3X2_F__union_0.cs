// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dcommon.h(277,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_3X2_F__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D2D_MATRIX_3X2_F__union_0__struct_0 __field_0 { get => InteropRuntime.Get<D2D_MATRIX_3X2_F__union_0__struct_0>(__bits, 0, 192); set => InteropRuntime.Set<D2D_MATRIX_3X2_F__union_0__struct_0>(value, __bits, 0, 192); }
        public D2D_MATRIX_3X2_F__union_0__struct_1 __field_1 { get => InteropRuntime.Get<D2D_MATRIX_3X2_F__union_0__struct_1>(__bits, 0, 192); set => InteropRuntime.Set<D2D_MATRIX_3X2_F__union_0__struct_1>(value, __bits, 0, 192); }
        public float[] m { get => InteropRuntime.GetArray<float>(__bits, 0, 192); set => InteropRuntime.SetArray<float>(value, __bits, 0, 192); }
    }
}
