// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(2932,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_MODE_INFO__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public DISPLAYCONFIG_TARGET_MODE targetMode { get => InteropRuntime.Get<DISPLAYCONFIG_TARGET_MODE>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_TARGET_MODE>(value, __bits, 0, 384); } }
        public DISPLAYCONFIG_SOURCE_MODE sourceMode { get => InteropRuntime.Get<DISPLAYCONFIG_SOURCE_MODE>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_SOURCE_MODE>(value, __bits, 0, 192); } }
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo { get => InteropRuntime.Get<DISPLAYCONFIG_DESKTOP_IMAGE_INFO>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[48]; InteropRuntime.Set<DISPLAYCONFIG_DESKTOP_IMAGE_INFO>(value, __bits, 0, 320); } }
    }
}
