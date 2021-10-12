// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2314,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS_FILTER__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong IncludeComputeOnly { get => InteropRuntime.GetUInt64(__bits, 0, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 1); } }
        public ulong IncludeDisplayOnly { get => InteropRuntime.GetUInt64(__bits, 1, 1); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 1, 1); } }
        public ulong Reserved { get => InteropRuntime.GetUInt64(__bits, 2, 62); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 2, 62); } }
    }
}
