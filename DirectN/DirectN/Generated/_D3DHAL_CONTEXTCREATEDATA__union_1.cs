// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(453,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CONTEXTCREATEDATA__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDS => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr lpDDSLcl => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
