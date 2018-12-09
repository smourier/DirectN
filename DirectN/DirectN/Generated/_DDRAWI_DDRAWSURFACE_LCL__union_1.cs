// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1503,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWCLIPPER_INT = DirectN._DDRAWI_DDRAWCLIPPER_INT;
using LPDDRAWI_DDRAWCLIPPER_LCL = DirectN._DDRAWI_DDRAWCLIPPER_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_LCL__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 144)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDClipper { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
        public IntPtr lp16DDClipper { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set => InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); }
    }
}
