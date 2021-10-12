// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2705,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_0 SetFault { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_1 Evict { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_1>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_1>(value, __bits, 0, 128); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_2 EvictByNtHandle { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_2>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_2>(value, __bits, 0, 64); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_3 GetVads { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3>(__bits, 0, 960); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3>(value, __bits, 0, 960); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_4 SetBudget { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_4>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_4>(value, __bits, 0, 128); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_5 SuspendProcess { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_5>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_5>(value, __bits, 0, 96); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_6 ResumeProcess { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_6>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_6>(value, __bits, 0, 64); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_7 GetBudget { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_7>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_7>(value, __bits, 0, 64); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_8 SetTrimIntervals { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_8>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_8>(value, __bits, 0, 96); } }
        public _D3DKMT_EVICTION_CRITERIA EvictByCriteria { get => InteropRuntime.Get<_D3DKMT_EVICTION_CRITERIA>(__bits, 0, 160); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_EVICTION_CRITERIA>(value, __bits, 0, 160); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_9 Wake { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_9>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_9>(value, __bits, 0, 32); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_10 Defrag { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_10>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_10>(value, __bits, 0, 320); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_11 DelayExecution { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_11>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_11>(value, __bits, 0, 192); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_12 VerifyIntegrity { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_12>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_12>(value, __bits, 0, 32); } }
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_13 DelayedEvictionConfig { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_13>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[120]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_13>(value, __bits, 0, 64); } }
    }
}
