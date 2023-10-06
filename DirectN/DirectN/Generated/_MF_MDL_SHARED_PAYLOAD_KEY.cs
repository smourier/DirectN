// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MF_MDL_SHARED_PAYLOAD_KEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _MF_MDL_SHARED_PAYLOAD_KEY__struct_0 combined {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_MF_MDL_SHARED_PAYLOAD_KEY__struct_0>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_MF_MDL_SHARED_PAYLOAD_KEY__struct_0>(value, __bits, 0, 128); } }
        public Guid GMDLHandle {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<Guid>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<Guid>(value, __bits, 0, 128); } }
    }
}
