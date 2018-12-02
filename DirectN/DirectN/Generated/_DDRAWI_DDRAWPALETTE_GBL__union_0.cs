// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1149,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWPALETTE_GBL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr dwReserved1 => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr hHELGDIPalette => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
