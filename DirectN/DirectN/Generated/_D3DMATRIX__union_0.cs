// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9types.h(92,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATRIX__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DMATRIX__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_D3DMATRIX__union_0__struct_0>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.Set<_D3DMATRIX__union_0__struct_0>(value, __bits, 0, 512); } }
        public float[] m { get => InteropRuntime.GetArray<float>(__bits, 0, 2048); set { if (__bits == null) __bits = new byte[256]; InteropRuntime.SetArray<float>(value, __bits, 0, 2048); } }
    }
}
