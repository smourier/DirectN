// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_COMPONENT_MAPPING__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_0 EngineDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_0>(value, __bits, 0, 32); } }
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_1 MonitorRefreshDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_1>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_1>(value, __bits, 0, 32); } }
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_2 MonitorDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_2>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_2>(value, __bits, 0, 32); } }
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_3 MemoryDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_3>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_3>(value, __bits, 0, 32); } }
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4 SharedDesc {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4>(value, __bits, 0, 32); } }
    }
}
