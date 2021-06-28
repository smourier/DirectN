// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2147,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS_FILTER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_ENUMADAPTERS_FILTER__struct_0 __field_0 { get => InteropRuntime.Get<_D3DKMT_ENUMADAPTERS_FILTER__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_ENUMADAPTERS_FILTER__struct_0>(value, __bits, 0, 64); } }
        public ulong Value { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
