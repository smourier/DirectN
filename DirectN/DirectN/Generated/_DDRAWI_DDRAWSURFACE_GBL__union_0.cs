// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1344,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_GBL__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpRectList => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public uint dwBlockSizeY => InteropRuntime.GetUInt32(__bits, 0, 32);
        public int lSlicePitch => InteropRuntime.GetInt32(__bits, 0, 32);
    }
}
