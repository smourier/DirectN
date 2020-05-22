// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2559,13)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0 GetNumVads { get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DKMT_VAD_DESC GetVad { get => InteropRuntime.Get<_D3DKMT_VAD_DESC>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_VAD_DESC>(value, __bits, 0, 320); } }
        public _D3DKMT_VA_RANGE_DESC GetVadRange { get => InteropRuntime.Get<_D3DKMT_VA_RANGE_DESC>(__bits, 0, 544); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_VA_RANGE_DESC>(value, __bits, 0, 544); } }
        public _D3DKMT_GET_GPUMMU_CAPS GetGpuMmuCaps { get => InteropRuntime.Get<_D3DKMT_GET_GPUMMU_CAPS>(__bits, 0, 896); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_GET_GPUMMU_CAPS>(value, __bits, 0, 896); } }
        public _D3DKMT_GET_PTE GetPte { get => InteropRuntime.Get<_D3DKMT_GET_PTE>(__bits, 0, 480); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_GET_PTE>(value, __bits, 0, 480); } }
        public _D3DKMT_GET_SEGMENT_CAPS GetSegmentCaps { get => InteropRuntime.Get<_D3DKMT_GET_SEGMENT_CAPS>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[112]; InteropRuntime.Set<_D3DKMT_GET_SEGMENT_CAPS>(value, __bits, 0, 256); } }
    }
}
