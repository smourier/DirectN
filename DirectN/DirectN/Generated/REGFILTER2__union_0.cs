// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(5070,36)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTER2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 272)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public REGFILTER2__union_0__struct_0 __field_0 { get => InteropRuntime.Get<REGFILTER2__union_0__struct_0>(__bits, 0, 1280); set { if (__bits == null) __bits = new byte[272]; InteropRuntime.Set<REGFILTER2__union_0__struct_0>(value, __bits, 0, 1280); } }
        public REGFILTER2__union_0__struct_1 __field_1 { get => InteropRuntime.Get<REGFILTER2__union_0__struct_1>(__bits, 0, 2176); set { if (__bits == null) __bits = new byte[272]; InteropRuntime.Set<REGFILTER2__union_0__struct_1>(value, __bits, 0, 2176); } }
    }
}
