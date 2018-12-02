// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2740,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETDRIVERSTATEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr dwhContext => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
