// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ENUMADAPTERS_FILTER__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ulong IncludeComputeOnly {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 0, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 0, 1); } }
        public ulong IncludeDisplayOnly {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 1, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 1, 1); } }
        public ulong IncludeVirtualGpuOnly {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 2, 1);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 2, 1); } }
        public ulong Reserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt64(__bits, 3, 61);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.SetUInt64(value, __bits, 3, 61); } }
    }
}
