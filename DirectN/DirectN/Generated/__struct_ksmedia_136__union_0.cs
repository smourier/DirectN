// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ksmedia_136__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 516)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Capabilities {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint SignalMode {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint LoadMedium {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public MEDIUM_INFO MediumInfo {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<MEDIUM_INFO>(__bits, 0, 96);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.Set<MEDIUM_INFO>(value, __bits, 0, 96); } }
        public TRANSPORT_STATE XPrtState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<TRANSPORT_STATE>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.Set<TRANSPORT_STATE>(value, __bits, 0, 64); } }
        public __struct_ksmedia_136__union_0__struct_0 Timecode {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__struct_ksmedia_136__union_0__struct_0>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.Set<__struct_ksmedia_136__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint dwTimecode {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint dwAbsTrackNumber {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public __struct_ksmedia_136__union_0__struct_1 RawAVC {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__struct_ksmedia_136__union_0__struct_1>(__bits, 0, 4128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[516]; InteropRuntime.Set<__struct_ksmedia_136__union_0__struct_1>(value, __bits, 0, 4128); } }
    }
}
