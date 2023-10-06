// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 584)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_SCATTERBLTS ScatterBlts {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_SCATTERBLTS>(__bits, 0, 4672);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[584]; InteropRuntime.Set<_D3DKMT_SCATTERBLTS>(value, __bits, 0, 4672); } }
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0>(__bits, 0, 704);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[584]; InteropRuntime.Set<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0>(value, __bits, 0, 704); } }
    }
}
