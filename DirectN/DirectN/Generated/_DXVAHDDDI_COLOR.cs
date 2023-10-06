// generated from <Windows SDK Path>\um\d3dumddi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_COLOR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVAHDDDI_COLOR_RGBA RGB {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXVAHDDDI_COLOR_RGBA>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXVAHDDDI_COLOR_RGBA>(value, __bits, 0, 128); } }
        public _DXVAHDDDI_COLOR_YCbCrA YCbCr {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_DXVAHDDDI_COLOR_YCbCrA>(__bits, 0, 128);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_DXVAHDDDI_COLOR_YCbCrA>(value, __bits, 0, 128); } }
    }
}
