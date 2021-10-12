// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8806,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_INHERITED_TIMING_INFO__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_INHERITED_TIMING_INFO__union_1__struct_0 __field_0 { get => InteropRuntime.Get<_DXGK_INHERITED_TIMING_INFO__union_1__struct_0>(__bits, 0, 104); set { if (__bits == null) __bits = new byte[13]; InteropRuntime.Set<_DXGK_INHERITED_TIMING_INFO__union_1__struct_0>(value, __bits, 0, 104); } }
        public uint DiagnosticInfo { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[13]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
