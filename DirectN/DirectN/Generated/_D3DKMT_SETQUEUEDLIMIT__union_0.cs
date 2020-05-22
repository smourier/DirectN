// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3352,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SETQUEUEDLIMIT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint QueuedPresentLimit { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public _D3DKMT_SETQUEUEDLIMIT__union_0__struct_0 __field_1 { get => InteropRuntime.Get<_D3DKMT_SETQUEUEDLIMIT__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_SETQUEUEDLIMIT__union_0__struct_0>(value, __bits, 0, 64); } }
    }
}
