// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY2__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DGPU_PHYSICAL_ADDRESS PhysicalAddress {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DGPU_PHYSICAL_ADDRESS>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.Set<_D3DGPU_PHYSICAL_ADDRESS>(value, __bits, 0, 128); } }
        public IntPtr Mdl {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[1]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
