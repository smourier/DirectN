// generated from <Windows SDK Path>\um\ddrawint.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_LOCAL__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDCOLORKEY ddckCKDestOverlay {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); } }
        public _DDCOLORKEY ddckCKDestBlt {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[8]; InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); } }
    }
}
