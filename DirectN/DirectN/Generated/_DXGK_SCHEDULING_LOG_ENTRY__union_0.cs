// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SCHEDULING_LOG_ENTRY__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE ContextStateChange {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXGK_SCHEDULING_LOG_CONTEXT_STATE_CHANGE>(value, __bits, 0, 128); } }
        public ulong[] ReservedOperationData {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<ulong>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetArray<ulong>(value, __bits, 0, 128); } }
    }
}
