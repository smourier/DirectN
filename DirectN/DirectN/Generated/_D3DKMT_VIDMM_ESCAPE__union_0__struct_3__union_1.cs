// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_3__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_GET_PTE_EXT GetPteExt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_GET_PTE_EXT>(__bits, 0, 8192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1024]; InteropRuntime.Set<_D3DKMT_GET_PTE_EXT>(value, __bits, 0, 8192); } }
    }
}
