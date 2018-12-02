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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDClipper => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr lp16DDClipper => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
