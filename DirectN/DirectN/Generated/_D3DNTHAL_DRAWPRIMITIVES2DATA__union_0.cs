// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(891,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DRAWPRIMITIVES2DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDVertex => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr lpVertices => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
