// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CONTROLINTERRUPT3__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_INTERRUPT_STATE InterruptState { get => InteropRuntime.Get<_DXGK_INTERRUPT_STATE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_INTERRUPT_STATE>(value, __bits, 0, 32); } }
        public _DXGK_CRTC_VSYNC_STATE CrtcVsyncState { get => InteropRuntime.Get<_DXGK_CRTC_VSYNC_STATE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_CRTC_VSYNC_STATE>(value, __bits, 0, 32); } }
    }
}
