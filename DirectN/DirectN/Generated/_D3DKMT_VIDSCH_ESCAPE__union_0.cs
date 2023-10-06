// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDSCH_ESCAPE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public bool PreemptionControl {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetBoolean(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public bool EnableContextDelay {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetBoolean(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public _D3DKMT_VIDSCH_ESCAPE__union_0__struct_0 TdrControl2 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_0>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_0>(value, __bits, 0, 64); } }
        public bool SuspendScheduler {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetBoolean(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetBoolean(value, __bits, 0, 32); } }
        public uint TdrControl {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint SuspendTime {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public _D3DKMT_VIDSCH_ESCAPE__union_0__struct_1 TdrLimit {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_1>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_VIDSCH_ESCAPE__union_0__struct_1>(value, __bits, 0, 64); } }
        public _D3DKMT_ESCAPE_PFN_CONTROL_COMMAND PfnControl {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DKMT_ESCAPE_PFN_CONTROL_COMMAND>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_D3DKMT_ESCAPE_PFN_CONTROL_COMMAND>(value, __bits, 0, 32); } }
    }
}
