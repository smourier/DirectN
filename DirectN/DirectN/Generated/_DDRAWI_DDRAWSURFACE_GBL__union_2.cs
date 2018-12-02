// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1355,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_GBL__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDD => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr lpDDHandle => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
