// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4552,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_VIRTUALMACHINEDATAFLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_VIRTUALMACHINEDATAFLAGS__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXGK_VIRTUALMACHINEDATAFLAGS__union_0__struct_0>(__bits, 0, 8); set => InteropRuntime.Set<_DXGK_VIRTUALMACHINEDATAFLAGS__union_0__struct_0>(value, __bits, 0, 8); }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
