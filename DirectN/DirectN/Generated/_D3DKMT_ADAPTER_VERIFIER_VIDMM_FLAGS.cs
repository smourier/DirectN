// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2815,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS__struct_0 __field_0 { get => InteropRuntime.Get<_D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DKMT_ADAPTER_VERIFIER_VIDMM_FLAGS__struct_0>(value, __bits, 0, 32); } }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
