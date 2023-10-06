// generated from <Windows SDK Path>\um\mfobjects.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPaletteEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _MFARGB ARGB {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_MFARGB>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_MFARGB>(value, __bits, 0, 32); } }
        public __MFAYUVSample AYCbCr {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<__MFAYUVSample>(__bits, 0, 32);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<__MFAYUVSample>(value, __bits, 0, 32); } }
    }
}
