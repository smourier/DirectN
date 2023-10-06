// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1072)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0 GetNumVads {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_0__struct_0>(value, __bits, 0, 32); } }
        public _D3DKMT_VAD_DESC GetVad {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_VAD_DESC>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_VAD_DESC>(value, __bits, 0, 320); } }
        public _D3DKMT_VA_RANGE_DESC GetVadRange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_VA_RANGE_DESC>(__bits, 0, 576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_VA_RANGE_DESC>(value, __bits, 0, 576); } }
        public _D3DKMT_GET_GPUMMU_CAPS GetGpuMmuCaps {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GET_GPUMMU_CAPS>(__bits, 0, 2112);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_GET_GPUMMU_CAPS>(value, __bits, 0, 2112); } }
        public _D3DKMT_GET_PTE GetPte {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GET_PTE>(__bits, 0, 8576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_GET_PTE>(value, __bits, 0, 8576); } }
        public _D3DKMT_GET_SEGMENT_CAPS GetSegmentCaps {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GET_SEGMENT_CAPS>(__bits, 0, 6208);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1072]; InteropRuntime.Set<_D3DKMT_GET_SEGMENT_CAPS>(value, __bits, 0, 6208); } }
    }
}
