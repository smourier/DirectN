// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_0 Mdl {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_0>(__bits, 0, 256);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_0>(value, __bits, 0, 256); } }
        public _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_1 ContiguousMemory {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_1>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_1>(value, __bits, 0, 192); } }
        public _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_2 Section {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_2>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_2>(value, __bits, 0, 192); } }
        public _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_3 IOSpace {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_3>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<_DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_3>(value, __bits, 0, 64); } }
    }
}
