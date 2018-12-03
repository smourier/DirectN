// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(92,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATRIX__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] __bits;
        public _D3DMATRIX__union_0__struct_0 __field_0 => InteropRuntime.Get<_D3DMATRIX__union_0__struct_0>(__bits, 0, 512);
        public float[] m => InteropRuntime.GetArray<float>(__bits, 0, 2048);
    }
}
