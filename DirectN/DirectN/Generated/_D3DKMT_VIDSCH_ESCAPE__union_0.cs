// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2633,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDSCH_ESCAPE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public bool PreemptionControl { get => InteropRuntime.GetBoolean(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public bool EnableContextDelay { get => InteropRuntime.GetBoolean(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public _D3DKMT_VIDSCH_ESCAPE__union_0__struct_0 TdrControl2 { get => InteropRuntime.Get<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_0>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_0>(value, __bits, 0, 64); } }
        public bool SuspendScheduler { get => InteropRuntime.GetBoolean(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public uint TdrControl { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint SuspendTime { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public _D3DKMT_VIDSCH_ESCAPE__union_0__struct_1 TdrLimit { get => InteropRuntime.Get<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_1>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_1>(value, __bits, 0, 64); } }
        public _D3DKMT_ESCAPE_PFN_CONTROL_COMMAND PfnControl { get => InteropRuntime.Get<_D3DKMT_ESCAPE_PFN_CONTROL_COMMAND>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_ESCAPE_PFN_CONTROL_COMMAND>(value, __bits, 0, 32); } }
    }
}
