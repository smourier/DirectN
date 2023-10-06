// generated from <Windows SDK Path>\um\wingdi.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_MODE_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DISPLAYCONFIG_TARGET_MODE targetMode {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DISPLAYCONFIG_TARGET_MODE>(__bits, 0, 384);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_TARGET_MODE>(value, __bits, 0, 384); } }
        public DISPLAYCONFIG_SOURCE_MODE sourceMode {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DISPLAYCONFIG_SOURCE_MODE>(__bits, 0, 160);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_SOURCE_MODE>(value, __bits, 0, 160); } }
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<DISPLAYCONFIG_DESKTOP_IMAGE_INFO>(__bits, 0, 320);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_DESKTOP_IMAGE_INFO>(value, __bits, 0, 320); } }
    }
}
