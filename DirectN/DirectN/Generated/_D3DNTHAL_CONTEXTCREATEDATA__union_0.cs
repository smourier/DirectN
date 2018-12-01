// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(275,5)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CONTEXTCREATEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpDDGbl => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr lpDDLcl => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
