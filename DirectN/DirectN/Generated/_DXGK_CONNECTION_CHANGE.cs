// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CONNECTION_CHANGE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong ConnectionChangeId {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
        public uint TargetId {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 64, 24);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt32(value, __bits, 64, 24); } }
        public _DXGK_CONNECTION_STATUS ConnectionStatus {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_CONNECTION_STATUS>(__bits, 88, 4);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_DXGK_CONNECTION_STATUS>(value, __bits, 88, 4); } }
        public uint Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 92, 4);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetUInt32(value, __bits, 92, 4); } }
        public _DXGK_CONNECTION_CHANGE__union_0 __union_4 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_CONNECTION_CHANGE__union_0>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_DXGK_CONNECTION_CHANGE__union_0>(value, __bits, 0, 64); } }
    }
}
