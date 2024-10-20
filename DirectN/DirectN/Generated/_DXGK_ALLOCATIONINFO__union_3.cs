// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFO__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_ALLOCATIONINFOFLAGS Flags {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_ALLOCATIONINFOFLAGS>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_ALLOCATIONINFOFLAGS>(value, __bits, 0, 32); } }
        public _DXGK_ALLOCATIONINFOFLAGS_WDDM2_0 FlagsWddm2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_ALLOCATIONINFOFLAGS_WDDM2_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_ALLOCATIONINFOFLAGS_WDDM2_0>(value, __bits, 0, 32); } }
    }
}
