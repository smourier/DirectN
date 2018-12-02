// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1977,5)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETDRIVERSTATEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDD => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public IntPtr dwhContext => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}
