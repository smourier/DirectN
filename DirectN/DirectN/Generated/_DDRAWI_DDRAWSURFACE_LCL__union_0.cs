// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1498,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWPALETTE_INT = DirectN._DDRAWI_DDRAWPALETTE_INT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_LCL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDPalette => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr lp16DDPalette => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
