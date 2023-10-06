// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_FAULT_ERROR_CODE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_FAULT_ERROR_CODE__union_0__struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_FAULT_ERROR_CODE__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_FAULT_ERROR_CODE__union_0__struct_0>(value, __bits, 0, 32); } }
        public _DXGK_FAULT_ERROR_CODE__union_0__struct_1 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_FAULT_ERROR_CODE__union_0__struct_1>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_FAULT_ERROR_CODE__union_0__struct_1>(value, __bits, 0, 32); } }
    }
}
