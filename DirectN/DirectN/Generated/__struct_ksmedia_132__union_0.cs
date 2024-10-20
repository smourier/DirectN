// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct __struct_ksmedia_132__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 520)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagDEVCAPS Capabilities {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<tagDEVCAPS>(__bits, 0, 736);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[520]; InteropRuntime.Set<tagDEVCAPS>(value, __bits, 0, 736); } }
        public uint DevPort {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[520]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public uint PowerState {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetUInt32(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[520]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
        public string pawchString {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetString(__bits, 0, 4160, UnmanagedType.LPWStr);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[520]; InteropRuntime.SetString(value, __bits, 0, 4160, UnmanagedType.LPWStr); } }
        public uint[] NodeUniqueID {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<uint>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[520]; InteropRuntime.SetArray<uint>(value, __bits, 0, 64); } }
    }
}
