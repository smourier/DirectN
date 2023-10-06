// generated from <Windows SDK Path>\um\mmeapi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERCONTROLW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagMIXERCONTROLW__union_0__struct_0 __field_0 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_0>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<tagMIXERCONTROLW__union_0__struct_0>(value, __bits, 0, 64); } }
        public tagMIXERCONTROLW__union_0__struct_1 __field_1 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<tagMIXERCONTROLW__union_0__struct_1>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<tagMIXERCONTROLW__union_0__struct_1>(value, __bits, 0, 64); } }
        public uint[] dwReserved {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.GetArray<uint>(__bits, 0, 192);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[24]; InteropRuntime.SetArray<uint>(value, __bits, 0, 192); } }
    }
}
